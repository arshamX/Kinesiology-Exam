using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Data.Models;
using Type = Data.Type;

namespace MMF1
{
    public partial class Form2 : Form
    {
        private int ShowTime = 0;
        private bool isAquzation = true;
        public Form2(int showtime, List<Input> inputs, Type feedBackType, bool isaquzation)
        {
            InitializeComponent();
            FillLabels(inputs, feedBackType);
            ShowTime = showtime;
            isAquzation = isaquzation;

        }
        private void FillLabels(List<Input> inputs, Type feedBackType)
        {
            for (int i = 0; i < inputs.Count; i++)
            {
                if (inputs[i].Data == "Start")
                {
                    continue;
                }
                else if (inputs[i].Data == "1" && (feedBackType == Type.IT || feedBackType == Type.MIX))
                {
                    lbl1.Text = $"IT{i} : {inputs[i].Time}";
                }
                else if (inputs[i].Data == "2" && (feedBackType == Type.IT || feedBackType == Type.MIX))
                {
                    lbl2.Text = $"IT{i} : {inputs[i].Time}";
                }
                else if (inputs[i].Data == "3" && (feedBackType == Type.IT || feedBackType == Type.MIX))
                {
                    lbl3.Text = $"IT{i} : {inputs[i].Time}";
                }
                else if (inputs[i].Data == "4" && (feedBackType == Type.IT || feedBackType == Type.MIX))
                {
                    lbl4.Text = $"IT{i} : {inputs[i].Time}";
                }
                else if (inputs[i].Data == "stop" && (feedBackType == Type.TMT || feedBackType == Type.MIX))
                {
                    lbl5.Text = $"TMT = {inputs[i].Time}";
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAquzation)
            {
                while (ShowTime > 0)
                {
                    Thread.Sleep(250);
                    ShowTime -= 250;
                }
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.OK;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isAquzation)
            {
                while (ShowTime > 0)
                {
                    Thread.Sleep(250);
                    ShowTime -= 250;
                }
                DialogResult = DialogResult.Cancel;
            }
            else
                DialogResult = DialogResult.Cancel;
        }
        private void endTimer_Tick(object sender, EventArgs e)
        {
            ShowTime -= 250;
            if (ShowTime <= 0)
            {
                DialogResult = DialogResult.OK;
            }
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            if (isAquzation)
            {
                endTimer.Enabled = true;
                endTimer.Start();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
