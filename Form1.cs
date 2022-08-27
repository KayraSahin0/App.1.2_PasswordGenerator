using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenereteP_Click(object sender, EventArgs e)
        {
            try
            {
                string randomString = string.Empty;
                char[] array = "0123456789qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM[];.,?@#$%^&*()".ToCharArray();
                Random random = new Random();
                int getnumber = Convert.ToInt32(txtLenght.Text);

                for (int i = 0; i < getnumber; i++)
                {
                    if (getnumber >= 30)
                    {
                        MessageBox.Show("Kime diyon gardas");
                        return;
                    }

                    int point = random.Next(1, array.Length);

                    if (!randomString.Contains(array.GetValue(point).ToString()))
                    {
                        randomString += array.GetValue(point);
                    }
                    else
                    {
                        i--;
                    }
                }

                
                lbPasswords.Items.Add(randomString);
            }
            catch (FormatException)
            {

                MessageBox.Show("Please enter the password length as a number");
            }

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = cmbFolderNames.Text;
                string[] saveFile = new string[lbPasswords.Items.Count];

                lbPasswords.Items.CopyTo(saveFile, 0);
                System.IO.File.WriteAllLines(folderPath, saveFile);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("File not selected to save");

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles(@"D:\OneDrive\Masaüstü", "*.txt");

            foreach (string file in filePaths)
            {
                cmbFolderNames.Items.Add(file);
            }
        }
    }
}
