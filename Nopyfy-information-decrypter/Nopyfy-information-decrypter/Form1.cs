using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace Nopyfy_information_decrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void decoderButton_Click(object sender, EventArgs e)
        {
            float cl;
            float litre;
            if (clTextBox.Text == "")
            {
                MessageBox.Show("Please fill the required field.");
            }
            if (litreTextBox.Text == "")
            {
                MessageBox.Show("Please fill the required field.");
            }

            else
            {
                try
                {
                    string textToDecrypt = clTextBox.Text;
                    string ToReturn = "";
                    string publickey = litreTextBox.Text;
                    string privatekey = publickey;
                    byte[] privatekeyByte = { };
                    privatekeyByte = System.Text.Encoding.UTF8.GetBytes(privatekey);
                    byte[] publickeybyte = { };
                    publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                    MemoryStream ms = null;
                    CryptoStream cs = null;
                    byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                    inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                    using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF8;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    string destination = "Victim_data.txt";
                    string[] lines = { ToReturn };
                    System.IO.File.WriteAllLines(destination, lines);
                    System.Diagnostics.Process.Start("Victim_data.txt");
                    MessageBox.Show("Decrypted Successfull...! Data is on 'Victim data.txt' File","Successfull....!",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    
                }
                catch (Exception ae)
                {
                    MessageBox.Show("Password or encrypted text is worng and exact 8 digit password are allowed(no greater or no smaller) ", "Plz, try gain");
                }


            }

        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            clTextBox.Text = "";
            litreTextBox.Text = "";
        }

        private void volumeConverter_Load(object sender, EventArgs e)
        {

        }

        private void ConvertCLTitelLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
