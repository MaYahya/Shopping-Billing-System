using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Shipping : UserControl
    {
      
        public Shipping()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string street = textBox2.Text;
            string city = textBox4.Text;
            string district = comboBox1.Text;
           int postal = int.Parse(textBox6.Text);
           double mobile = double.Parse(textBox5.Text);

            label13.Text = name;
            label12.Text = street;
            label10.Text = city;
            label9.Text = district;
            label8.Text = postal.ToString();
            label11.Text = mobile.ToString();
            panel1.Hide();
            panel3.Show();
           
        }

        private void Shipping_Load(object sender, EventArgs e)
        {
            string[] districts = new string[]
{
        "Ampara", "Anuradhapura", "Badulla", "Batticaloa", "Colombo", "Galle",
        "Gampaha", "Hambantota", "Jaffna", "Kalutara", "Kandy", "Kegalle",
        "Kilinochchi", "Kurunegala", "Mannar", "Matale", "Matara", "Moneragala",
        "Mullaitivu", "Nuwara Eliya", "Polonnaruwa", "Puttalam", "Ratnapura", "Trincomalee", "Vavuniya"
};

            comboBox1.Items.AddRange(districts);
        }

       
        private void okButton_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox5.Clear(); comboBox1.SelectedIndex = -1;
            textBox6.Clear(); textBox4.Clear();
            panel3.Visible=false;
            panel1.Visible = true;
        }

        public string Label15Text
        {
            get { return label15.Text; }
            set { label15.Text = value; }
        }

      

    }
}
