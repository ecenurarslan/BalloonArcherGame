using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archer.Desktop
{
    public partial class Form2 : Form
    {
        
        string username;
        int mevcutPuan;
        string archer;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayitPanel.Visible = false;
            girisPanel.Visible = true;

            
        }

       

        private void buttonKaydol_Click_1(object sender, EventArgs e)
        {
            mevcutPuan = 0;

            if (radioButton1.Checked == true)
            {
                archer = "cupid";
            }

            else if (radioButton2.Checked == true)
            {
                archer = "centaur";
            }

            else return;

            if (usernameTextBox.Text.Length > 0)
            {
                username = usernameTextBox.Text;
            }

            else return;

            System.IO.StreamReader readFile = new System.IO.StreamReader(@"Kayitlar\kayit.txt");
            string fileCopy = readFile.ReadToEnd();
            readFile.Close();

            System.IO.StreamWriter file = new System.IO.StreamWriter(@"Kayitlar\kayit.txt");
            file.WriteLine(fileCopy + username + " " + mevcutPuan + " " + archer );
            file.Close();

            Form1 form1 = new Form1(username, mevcutPuan, archer);
            form1.Show();
            this.Hide();
        }

        private void buttonGiris_Click_1(object sender, EventArgs e)
        {
            username = textBox1.Text;
            string line;
            char[] thisLine;
            int param = 0;
            // string dizisi mi öyke olmasın tek tek alıcam username puan falan 
            string[] parametreler;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"Kayitlar\kayit.txt");

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(username + " "))
                {
                    thisLine = line.ToCharArray(); //

                    parametreler = line.Split(' ');
                    mevcutPuan = Convert.ToInt32(parametreler[1]);
                    archer = parametreler[2];

                    /*for (int i = username.Length+1; i < line.Length; i++)
                    {
                        if (thisLine[i] != ' ' && param == 0) 
                        {
                           mevcutPuan += (thisLine[i]); 
                        }
                        else if (thisLine[i] == ' ')
                        {
                            param = 1;
                        }
                        if (param == 1)
                        {
                            archer += thisLine[i];
                        }

                    }*/

                    Form1 form1 = new Form1(username, mevcutPuan, archer);
                    form1.Show();
                    this.Hide();
                }

            }

            file.Close();
        }
    }
}
