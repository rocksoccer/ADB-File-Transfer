using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ADB_File_Transfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            //open the file select window
            FileSelector = new OpenFileDialog();

            if (FileSelector.ShowDialog()==DialogResult.OK)
            {
                FileLabel.Text = FileSelector.FileName;
            }
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            TransferProgressBar.Visible = true;
            OutputTextBox.Text = "Transfering " + FileSelector.FileName + " to /sdcard/" + FileSelector.SafeFileName + Environment.NewLine;

            BackgroundWorker workThread = new BackgroundWorker();
            workThread.DoWork += new DoWorkEventHandler(adbThread_doWork);
            workThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(adbThread_RunWorkerCompleted);
            workThread.RunWorkerAsync();
        }

        private StreamReader sr;

        private void adbThread_doWork(object sender, DoWorkEventArgs e)
        {
            Process adbProcess = new Process();
            adbProcess.StartInfo.FileName = "adb.exe";
            //adbProcess.StartInfo.Arguments = "devices";
            //adbProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            adbProcess.StartInfo.CreateNoWindow = true;
            adbProcess.StartInfo.Arguments = "push " + FileSelector.FileName + " /sdcard/" + FileSelector.SafeFileName;
            adbProcess.StartInfo.UseShellExecute = false;
            adbProcess.StartInfo.RedirectStandardOutput = true;
            adbProcess.Start();

            sr = adbProcess.StandardOutput;
            
            adbProcess.WaitForExit();
            adbProcess.Close();
        }

        private void adbThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OutputTextBox.Text += sr.ReadToEnd() + Environment.NewLine;
            TransferProgressBar.Visible = false;
            OutputTextBox.Text += "Transfer is completed.";
        }
    }
}
