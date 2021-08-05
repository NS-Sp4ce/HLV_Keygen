using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keygen
{
    public partial class MainForm : Form
    {
        public MainForm( )
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogInfo("Welcome.");
        }

        private void github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openLink(this.github.Text.ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openLink(this.downloadLink.Text.ToString());
        }

        private void Genbutton_Click(object sender, EventArgs e)
        {
            if (ModifyHostsFile("0.0.0.0 www.apacheviewer.com"))
            {
                string key=PreGenerateKey();
                LogSuccess("Key:[" + key + "]");
            }
        }

        public string PreGenerateKey( )
        {
            List<string> data = new List<string>();
            Random ran = new Random();
            data.Add("F-");
            int num = ran.Next(0, 9);
            int num16 = ran.Next(0, 15);
            int num23 = ran.Next(2, 3);
            int num100 = ran.Next(0, 999);
            string hex = num16.ToString("X");
            data.Add(hex);
            data.Add(hex);
            data.Add("I-ALV-");
            data.Add(num100.ToString().PadLeft(3, '0'));
            data.Add("-");
            data.Add(num.ToString());
            data.Add(num23.ToString());
            string preData = string.Join("", data.ToArray());
            string finalkey=generateKey(preData);
            return finalkey;
        }

        public string generateKey(string data)
        {
            string hexData = data.Replace('-', ':');
            string[] dataArray = data.Split(new char[] { '-' });
            string tempData = string.Join("", dataArray);
            int num = 0;
            foreach (int str in hexData)
            {
                string hexCode = str.ToString("X");
                //calc verify code
                if (str % 2 == 0)
                {
                    num = num + 1;
                }
            }
            //append verify code to data
            tempData = tempData + num.ToString();
            //Convert to hex
            byte[] temp_ = Encoding.Default.GetBytes(tempData);
            string hexString = BitConverter.ToString(temp_);
            hexString = hexString.Replace("-", "");
            hexString = hexString.Insert(2,"-");
            hexString = hexString.Insert(9, "-");
            hexString = hexString.Insert(16, "-");
            hexString = hexString.Insert(23, "-");
            return hexString;
        }
    public void openLink(string url)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch
            {
                System.Diagnostics.Process.Start("iexplore.exe", url);
            }
        }


        /*
         modify hosts file
         */
        public bool ModifyHostsFile(string data)
        {
            try
            {
                string text = System.IO.File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"));
                if (!text.Contains("0.0.0.0 www.apacheviewer.com"))
                {
                    using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts")))
                    {
                        w.WriteLine(data);
                        LogSuccess("Modify hosts file success!");
                        return true;
                    }
                }
                else
                {
                    LogWarning("Hosts file already modified!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogError(ex.Message);
                return false;
            }
        }

        /**
         Log Funcions
         */
        public delegate void LogAppendDelegate(Color color, string text);
        public void LogAppend(Color color, string text)
        {
            if (this.Outputbox.Text.Length > 10000)
            {
                this.Outputbox.Clear();
            }
            this.Outputbox.SelectionColor = color;
            this.Outputbox.HideSelection = false;
            this.Outputbox.AppendText(text + Environment.NewLine);
        }
        public void LogError(string text)
        {
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            this.Outputbox.Invoke(la, Color.Red, "[" + DateTime.Now + "] " + text);
        }
        public void LogWarning(string text)
        {
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            this.Outputbox.Invoke(la, Color.Violet, "[" + DateTime.Now + "] " + text);
        }
        public void LogMessage(string text)
        {
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            this.Outputbox.Invoke(la, Color.Black, "[" + DateTime.Now + "] " + text);
        }
        public void LogInfo(string text)
        {
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            this.Outputbox.Invoke(la, Color.BlueViolet, "[" + DateTime.Now + "] " + text);
        }
        public void LogSuccess(string text)
        {
            LogAppendDelegate la = new LogAppendDelegate(LogAppend);
            this.Outputbox.Invoke(la, Color.Green, "[" + DateTime.Now + "] " + text);
        }
        delegate void DelegateAddItem(ListViewItem lvi);

    }
}
