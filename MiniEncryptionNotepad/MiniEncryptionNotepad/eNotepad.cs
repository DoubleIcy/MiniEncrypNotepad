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

        public eNotepad()
        {
            InitializeComponent(); 
            try
            {
                ds.ReadXml("c:\\windows\\KeyInfo.xml");
                key.setKeyList = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                key.Randomkey();
            }
        }

        private void toolStripButton_Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文本文件 (*.txt)|*.txt|xml文件 (*.xml)|*.xml|ini文件 (*.ini)|*.ini|All files (*.*)|*.*";
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

        }

        private void toolStripButton_Mini_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_Edit_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_Pass_Click(object sender, EventArgs e)
        {

        }

     

 
 
 
    }
}
