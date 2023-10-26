using Data.Models;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Data
{
    public enum Type
    {
        IT,
        TMT,
        MIX
    }
    public delegate bool ShowDelegate(int showtime, List<Input> inputs, Type feedBackType, bool isaquzation);
    public delegate void ResetForm();
    public delegate void ButtonStop(bool state);
    public class DataBase
    {
        private ShowDelegate Show;
        private ResetForm Resetform;
        private List<User> Users = new List<User>();
        private SerialPort Serial = new SerialPort();
        private Thread ReaderT;
        private User TargetUser;
        private TestInfo TargetTestInfo;
        private ButtonStop buttonStop;
        public DataBase(ShowDelegate sHow, ResetForm resetform, ButtonStop button)
        {
            Show = sHow;
            Start();
            Resetform = resetform;
            buttonStop = button;
        }
        private void Start()
        {
            Serial = new SerialPort()
            {
                BaudRate = 19200,
                PortName = "COM3",
            };
            Serial.Open();
        }
        private void Reader()
        {
            ChangeStage(true);
            buttonStop(false);
            int i = 0;
            int delay = 0;
            List<Input> train = new List<Input>();
            while (i < TargetTestInfo.Repeat)
            {
                string inputstr = "";
                try
                {
                    inputstr = Serial.ReadLine().ToString();
                    Input input = new Input(inputstr);
                    train.Add(input);
                }
                catch { }
                if (train.Count == 6)
                {
                    TargetUser.AllData.AddRange(train);
                    bool condition = TargetTestInfo.Frequency == 3 ? i % TargetTestInfo.Frequency != 0 : i % TargetTestInfo.Frequency == 0;
                    ChangeStage(false);
                    buttonStop(true);
                    if (condition)
                    {
                        Thread.Sleep(TargetTestInfo.FeedBackDelay);
                        if (Show(TargetTestInfo.ShowTime, train, TargetTestInfo.TestType, TargetTestInfo.IsAquzation))
                            TargetUser.PreferedData.AddRange(train);
                    }
                    train = new List<Input>();
                    delay = TargetTestInfo.RepeatDelay -2000 ;
                    Thread.Sleep(delay >=0 ? delay : 0);
                    buttonStop(false);
                    ChangeStage(true);
                    i++;
                }
            }
            buttonStop(true);
            ChangeStage(false);
            Users.Add(TargetUser);
            Resetform();
        }
        public void IntilizeThreade()
        {
            ReaderT = new Thread(new ThreadStart(Reader));
            ReaderT.Start();
        }
        public void StopThread()
        {

            if(ReaderT.IsAlive) ReaderT.Abort();
            Serial.Write("End");
            Serial.Close();
            Serial = new SerialPort() {
                PortName  = "COM3",
                BaudRate = 19200
            };
            Serial.Open();
            Users.Add(TargetUser);
            Resetform();
        }
        private void ChangeStage(bool isready)
        {
            try
            {
                if (isready)
                {
                    Serial.Write("Start");
                }
                else
                {
                    Serial.Write("Stop");
                }
            }
            catch
            {
                ChangeStage(isready);
            }
        }
        public void SetValues(User targetuser, TestInfo targettest)
        {
            TargetUser = targetuser;
            TargetTestInfo = targettest;
        }
        public bool SaveFile(string address)
        {
            try
            {
                using (XLWorkbook workbook = new XLWorkbook(address))
                {
                    int row = 1, column = 1;
                    var worksheet = workbook.Worksheet("All Data");
                    var worksheet2 = workbook.Worksheet("Selected Data");
                    try
                    {
                        row = worksheet.LastRowUsed().RowNumber()+1;
                    }
                    catch { }
                    foreach (User user in Users)
                    {
                        var cell = worksheet.Cell(row, 1);
                        var cell2 = worksheet2.Cell(row, 1);
                        cell.Value = user.Name + "  " +user.LastName;
                        cell2.Value = user.Name + "  " + user.LastName;

                        var cellID = worksheet.Cell(row, 2);
                        var cell2ID = worksheet2.Cell(row, 2);
                        cellID.Value = user.ID;
                        cell2ID.Value = user.ID;

                        var cellgroup = worksheet.Cell(row, 3);
                        var cell2group = worksheet2.Cell(row, 3);
                        cellgroup.Value = user.Group;
                        cell2group.Value = user.Group;

                        var cellTest = worksheet.Cell(row, 4);
                        var cell2Test = worksheet2.Cell(row, 4);
                        cellTest.Value = user.TestName;
                        cell2Test.Value = user.TestName;
                        column = 5;
                        foreach (Input input in user.AllData)
                        {
                            if (input.Data == "Start")
                            {
                                continue;
                            }
                            cell = worksheet.Cell(row, column);
                            string[] tempstr = input.Time.Split('.');
                            int milisecond = Int32.Parse(tempstr[0]) * 1000 + Int32.Parse(tempstr[1]);
                            cell.Value = $"{milisecond.ToString()}";
                            column++;
                        }
                        column = 5;
                        foreach (Input input in user.PreferedData)
                        {
                            if (input.Data == "Start")
                            {
                                continue;
                            }
                            cell2 = worksheet2.Cell(row, column);
                            string[] tempstr = input.Time.Split('.');
                            int milisecond = Int32.Parse(tempstr[0]) * 1000 + Int32.Parse(tempstr[1]);
                            cell2.Value = $"{milisecond.ToString()}";
                            column++;
                        }
                        row++;
                    }
                    worksheet.Columns().AdjustToContents();
                    worksheet.RangeUsed().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    worksheet.RangeUsed().Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    worksheet.RangeUsed().Style.Alignment.WrapText = true;
                    worksheet2.Columns().AdjustToContents();
                    worksheet2.RangeUsed().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    worksheet2.RangeUsed().Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    worksheet2.RangeUsed().Style.Alignment.WrapText = true;
                    workbook.SaveAs(address);
                    Users.Clear();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool ThreadState()
        {
            if(ReaderT != null)
            {
                return ReaderT.IsAlive;
            }
            return false;
        }
    }
}
