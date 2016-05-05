using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using System.IO; 

namespace MiniEncryptionNotepad
{
    public partial class eNotepad : Form
    {

        public static EncryClass key = new EncryClass();
        private DataSet ds = new DataSet();
        private bool ifDecodeSpace = true;
        public eNotepad()
        {
            InitializeComponent(); 

            string keyfilename = Application.StartupPath + "\\Key.txt"; 
            try
            {
                string strpass=ReadFromFile(keyfilename);
                if (string.IsNullOrEmpty(strpass.Trim()))
                    throw new Exception();
                key.setKeyList = strpass;
            }
            catch
            {
                string strpass = key.Randomkey();
                WriteToFile(keyfilename, strpass);
            }
        }

        private void toolStripButton_Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "text Files (*.txt)|*.txt|xml Files (*.xml)|*.xml|ini Files (*.ini)|*.ini|All files (*.*)|*.*";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                string file = openFileDialog1.SafeFileName;
                string[] files = openFileDialog1.SafeFileNames;

                StringBuilder s = new StringBuilder();
                string fullfile = ((System.Windows.Forms.FileDialog)(openFileDialog1)).FileName;
                StreamReader fr = new StreamReader(fullfile);
                do
                {
                    s.Append(fr.ReadLine());
                }
                while (!fr.EndOfStream);

                fr.Close();

                string[] slist = s.ToString().Split('\\');
                char[] chlist = new char[slist.Length];
                StringBuilder sbil = new StringBuilder();
                int j;
                for (int i = 0; i < slist.Length; i++)
                {
                    if (!int.TryParse(slist[i], out j))
                        continue;

                    chlist[i] = Convert.ToChar(j);
                    sbil.Append(chlist[i]);
                } 

                notepad.Text = key.deCode(sbil.ToString());
            }
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "text Files (*.txt)|*.txt|xml Files (*.xml)|*.xml|ini Files (*.ini)|*.ini|All files (*.*)|*.*";
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                DeSpace();
                string str = key.encode(notepad.Text);
                notepad.Text = key.encodeListNumStr;

                WriteToFile(((FileDialog)saveFileDialog1).FileName, key.encodeListNumStr);
            }
        }

        private void toolStripButton_Mini_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.FreeNotepad.Icon = this.Icon;
            this.Hide();
        }
  
        /// <summary>
        /// CLEAR THE DOUBLE SPACES TO SINGLE,SO THAT THERE'S NO PLACE EASY TO DECODE
        /// </summary>
        public void DeSpace()
        {
            if (!ifDecodeSpace)
                return;

            string str = notepad.Text;
            while (str.Contains("  "))
            {
                str = str.Replace("      ", " ").Replace("  ", " ");
            }
            notepad.Text = str;
        }
        public void WriteToFile(string file , string text)
        {
            StreamWriter SW; 
            SW = File.CreateText(file);
            SW.WriteLine(text);
            SW.Close();
        }

        private string ReadFromFile(string filename)
        {
            StreamReader streamReader = File.OpenText(filename);
            string strReadOutLine = null;
            StringBuilder sb = new StringBuilder();
 
            strReadOutLine = streamReader.ReadLine();
            while (strReadOutLine != null)
            {
                sb.Append(strReadOutLine);
                strReadOutLine = streamReader.ReadLine();
            }
            streamReader.Close();
            return sb.ToString();
        }

        private void FreeNotepad_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clickYX(e);
        }

        private void clickYX(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Show();
            }

            if (e.Button == MouseButtons.Left)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
            }
        }
 
    }
}
