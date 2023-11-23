using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int rowIndex = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Title";
            dataGridView1.Columns[1].Name = "Qty";
            dataGridView1.Columns[2].Name = "Price";
        }

        private int GetExistingRowIndex(string labelText)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == labelText)
                {
                    return row.Index;
                }
            }
            return -1;
        }
        private int GetColumn2Sum()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    sum += (int)row.Cells[2].Value;
                }
            }
            return sum;

        }
       
        private void Clickss(Panel panel, int b)
        {

            
            string labelText = panel.Controls.OfType<Label>().FirstOrDefault()?.Text;
            if (!string.IsNullOrEmpty(labelText))
            {
                int existingRowIndex = GetExistingRowIndex(labelText);
                if (existingRowIndex != -1)
                {
                    // If a row already exists for the label text, increment the click count.
                    int clickCount = (int)dataGridView1.Rows[existingRowIndex].Cells[1].Value;
                    dataGridView1.Rows[existingRowIndex].Cells[1].Value = clickCount + 1;
                    dataGridView1.Rows[existingRowIndex].Cells[2].Value = (clickCount + 1) * b;
                }
                else
                {
                    // Otherwise, add a new row with the label text and click count of 1.
                   rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = labelText;
                    dataGridView1.Rows[rowIndex].Cells[1].Value = 1;
                    dataGridView1.Rows[rowIndex].Cells[2].Value = b;
                    rowIndex++;
                }



            }

            int sum = GetColumn2Sum();
            label20.Text = sum.ToString() + ".00 LKR";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clickss(panel6,2500);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Clickss(panel5,1500) ;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clickss(panel7, 2390);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clickss(panel8, 1999);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clickss(panel9, 800);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clickss(panel10, 3200);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Clickss(panel12, 1999);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clickss(panel11, 999);
        }


        private void Hideoption()
        {
            for (int i = 5; i <= 12; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Hide();
                }
            }
            for (int i = 18; i <= 21; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Hide();
                }
            }
            for (int i = 13; i <= 17; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Show();
                }
            }

        }
        private void Hideoption2()
        {
            for (int i = 5; i <= 17; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Hide();
                }
            }
            for (int i = 18; i <= 21; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Show();
                }
            }
        }
        private void Showoption()
        {
            for (int i = 5; i <= 21; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Show();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Showoption();
            shipping2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hideoption(); shipping2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hideoption2(); shipping2.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Clickss(panel15, 1199);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Clickss(panel14, 989);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Clickss(panel17, 489);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Clickss(panel16, 690);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Clickss(panel18, 500);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Clickss(panel19, 789);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Clickss(panel20, 600);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Clickss(panel21, 1400);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            shipping2.Label15Text = label20.Text;
            shipping2.Show();
            for (int i = 5; i <= 21; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Hide();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            label20.Text = "0.00 LKR";
        }

    }
}
