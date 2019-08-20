using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = dateTimePicker1.Value.ToShortDateString();
            txtYear.Text = dateTimePicker1.Value.Year.ToString();
            txtMonth.Text = dateTimePicker1.Value.Month.ToString();
            txtDay.Text = dateTimePicker1.Value.Day.ToString();
            txtTime.Text = dateTimePicker1.Value.TimeOfDay.ToString();

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            if (dateTimePicker1.Value.Month.Equals(12) || dateTimePicker1.Value.Month.Equals(1) || dateTimePicker1.Value.Month.Equals(2))
            {
                txtSeason.Text = "It is Winter";
                pictureBox.Image = Image.FromFile(@"C:\Users\Trainee\OneDrive\Software Development Traineeship\CSharp\DateTimePicker\DateTimePicker\images\snow.jpg");
            }
            else if (dateTimePicker1.Value.Month.Equals(3) || dateTimePicker1.Value.Month.Equals(4) || dateTimePicker1.Value.Month.Equals(5))
            {
                txtSeason.Text = "It is Spring";
                pictureBox.Image = Image.FromFile(@"C:\Users\Trainee\OneDrive\Software Development Traineeship\CSharp\DateTimePicker\DateTimePicker\images\spring.jpg");
            }
            else if (dateTimePicker1.Value.Month.Equals(6) || dateTimePicker1.Value.Month.Equals(7) || dateTimePicker1.Value.Month.Equals(8))
            {
                txtSeason.Text = "It is Summer";
                pictureBox.Image = Image.FromFile(@"C:\Users\Trainee\OneDrive\Software Development Traineeship\CSharp\DateTimePicker\DateTimePicker\images\beach.jpg");
            }
            else if (dateTimePicker1.Value.Month.Equals(9) || dateTimePicker1.Value.Month.Equals(10) || dateTimePicker1.Value.Month.Equals(11))
            {
                txtSeason.Text = "It is Autumn";
                pictureBox.Image = Image.FromFile(@"C:\Users\Trainee\OneDrive\Software Development Traineeship\CSharp\DateTimePicker\DateTimePicker\images\leaves.jpg");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
