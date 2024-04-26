using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Collections.ArrayList course = new System.Collections.ArrayList();
            course.Add("Bachelor in Science in Computer Science");
            course.Add("Bachelor in Science in Information Technology");
            course.Add("Bachelor in Science in Information System");
            course.Add("Bachelor in Science in Computer Engineering");

            string[] month = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Decemner "};
            for (int i = 0; i < 12; i++) 
            {
                Month.Items.Add(month[i]);
            }
            for (int i = 1900; i <= 2024; i++)
            {
                Year.Items.Add(i);
            }
            for(int i = 1;  i <= 30; i++)
            {
                Day.Items.Add(i);
            }


            for(int i = 0; i < 4; i++)
            {
                Program.Items.Add(course[i]);
            } 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gen = null;
            string FName = FirstN.Text;
            string LName = LastN.Text;
            string MName = MiddleN.Text;
            string day = Day.Text;
            string year = Year.Text;
            string month = Month.Text;
            string program = Program.Text;

            if (Male.Checked == true)
            {
                gen = "Male";
            }
            else if (Female.Checked == true)
            {
                gen = "Female";
            }
            if (Month.Text.Equals("-Month-") && Day.Text.Equals("-Day-") && Year.Text.Equals("-Year-"))
            {
                if (!Male.Checked && !Female.Checked)
                {
                    firstMess(MName, LName, FName, program);
                }
                else if (Male.Checked || Female.Checked)
                {
                    firstMess(MName, LName, FName, program, gen);

                }


            }
            else
            {
                firstMess(MName, LName, FName, program, gen, day, month, year);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            OpenFileDialog openpic = new OpenFileDialog();
            openpic.ShowDialog(this);
            if (openpic.ShowDialog() == DialogResult.OK)
            {
                Picture.Image = Bitmap.FromFile(openpic.FileName);
            }
        }
        public void firstMess(string Mname, string Lname, string Fname, string prog)
        {
            MessageBox.Show("Student Name: " + Fname + " " + Mname + " " + Lname
                + "\nProgram: " + Program.Text);
        }
        public void firstMess(string Lname, string Fname, string prog)
        {
            MessageBox.Show("Student Name: " + Fname + " " + Lname
                + "\nProgram: " + Program.Text);
        }

        public void firstMess(string Mname, string Lname, string Fname, string prog, string gen)
        {
            MessageBox.Show("Student Name: " + Fname + " " + Mname + " " + Lname
                + "\nGender: " + gen
                + "\nProgram: " + Program.Text);
        }
        public void firstMess(string Mname, string Lname, string Fname, string prog, string gen, string day, string month, string year)
        {
            MessageBox.Show("Student Name: " + Fname + " " + Mname + " " + Lname
                + "\nGender: " + gen
                + "\nBirth of day: " + day + "/" + month + "/" + year
                + "\nProgram: " + Program.Text);
        }
    }
}
