using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Data;
using Data.Models;
using Type = Data.Type;

namespace MMF1
{
    public partial class Form1 : Form
    {
        #region CPU
        private string GetCpuSerialNumber()
        {
            string command = "wmic cpu get ProcessorId /format:list";
            string output = ExecuteCommand(command);
            string[] lines = output.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                if (line.StartsWith("ProcessorId="))
                {
                    return line.Substring("ProcessorId=".Length).Trim();
                }
            }

            return string.Empty;
        }
        private string ExecuteCommand(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c " + command;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                return output;
            }
        }
        #endregion
        private Type TestType;
        private bool isAquzation = true;
        private int Frequency;
        private DataBase DataBase;
        private int Time;
        public Form1()
        {
            string CPU = GetCpuSerialNumber();
            InitializeComponent();
            DataBase = new DataBase(ShowForm2, ResetForm, StopEnabeled);
            Button.CheckForIllegalCrossThreadCalls = false;
            GroupBox.CheckForIllegalCrossThreadCalls = false;
        }
        private void cbTestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTestType.SelectedIndex == 0 )
            {
                isAquzation = true;
                nudFeedBack.Enabled = true;
                nudShowTime.Enabled = true;
                nudDelayKR.Enabled = true;
                cbFrequency.Enabled = true;
                nudFeedBack.Value = 1;
                nudShowTime.Value = 1;
                nudDelayKR.Value = 1;
                cbFrequency.SelectedIndex = 3;
            }
            else if (cbTestType.SelectedIndex != 0)
            {
                isAquzation = false;
                nudFeedBack.Enabled = false;
                nudShowTime.Enabled = false;
                nudDelayKR.Enabled = false;
                cbFrequency.Enabled = false;
                nudFeedBack.Value = 1;
                nudShowTime.Value = 1;
                nudDelayKR.Value = 1;
                cbFrequency.SelectedIndex = 3;
            }
            if (cbTestType.SelectedIndex == 7)
            {
                cbTestType.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                cbTestType.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbTestType.SelectedIndex = 0;
            cbFrequency.SelectedIndex = 3;
            rbtnIT.Checked = true;
            TimerStopBtn.Enabled = true;
            TimerStopBtn.Start();
        }
        private void rbtnITTMT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnIT.Checked)
            {
                TestType = Type.IT;
            }
            else if (rbtnTMT.Checked)
            {
                TestType = Type.TMT;
            }
            else if (rbtnITTMT.Checked)
            {
                TestType = Type.MIX;
            }
        }
        private void cbFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFrequency.SelectedIndex == 0)
            {
                Frequency = 4;
            }
            else if (cbFrequency.SelectedIndex == 1)
            {
                Frequency = 2;
            }
            else if (cbFrequency.SelectedIndex == 2)
            {
                Frequency = 3;
            }
            else if (cbFrequency.SelectedIndex == 3)
            {
                Frequency = 1;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            User tempUser = new User(txtName.Text, txtLastName.Text, txtGroup.Text, txtCode.Text,cbTestType.Text);
            TestInfo tempInfo = new TestInfo(((int)nudRepeat.Value), ((int)nudFeedBack.Value), ((int)nudShowTime.Value), ((int)nudDelayKR.Value), Frequency, TestType, isAquzation);
            DataBase.SetValues(tempUser, tempInfo);
            //Thread.Sleep(100);
            DataBase.IntilizeThreade();
            btnStart.Enabled = false;
            gbPersonalInfo.Enabled = false;
            gbTestInfo.Enabled = false;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            DataBase.StopThread();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnExport.Enabled = true;
            gbPersonalInfo.Enabled = true;
            gbTestInfo.Enabled = true;
        }
        private void ResetForm()
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnExport.Enabled = true;
            gbPersonalInfo.Enabled = true;
            gbTestInfo.Enabled = true;
        }
        private bool ShowForm2(int showtime, List<Input> inputs, Type feedBackType, bool isaquzation)
        {
            var SaveForm = new Form2(showtime, inputs, feedBackType, isaquzation).ShowDialog();
            if (SaveForm == DialogResult.OK || SaveForm == DialogResult.None)
                return true;
            else
                return false;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (DataBase.SaveFile("MMF output.xlsx"))
            {
                MessageBox.Show("Resultes has been successfully saved ", "success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("There was a problem while creating the results file", "Error", MessageBoxButtons.OK);
            }
        }
        private void StopEnabeled(bool state)
        {
            if (state == true)
            {
                btnStop.Enabled = true;
            }
            else
            {
                btnStop.Enabled = false;
            }
        }

        private void TimerStopBtn_Tick(object sender, EventArgs e)
        {
            if (DataBase.ThreadState())
            {
                btnExport.Enabled = false;
            }
            else { btnExport.Enabled = true; }
        }
    }
}
