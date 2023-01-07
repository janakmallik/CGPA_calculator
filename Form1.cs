//created by @janakmallik

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace CGPA_calculator
{

    //var CGPA_cals = new List<CGPA_cal>();
    public partial class Form1 : Form
    {
        //var CGPA_cals = new List<CGPA_cal>();
        public Form1()
        {
            InitializeComponent();
            var CGPA_cals = new List<CGPA_cal>();
            var a = new List<float>();
            var b = new List<float>();
            //textBox1.ReadOnly = false;
            richTextBox1.ReadOnly = true;
            textBox4.ReadOnly= true;
            textBox5.ReadOnly= true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richTextBox1.ReadOnly = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView1.DataSource = items;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        float cgpa_num;
        float credit_num;
        List<float> cg = new List<float>();
        List<float> cr = new List<float>();
        private void button1_Click_1(object sender, EventArgs e)
        {
            

            if ((!String.IsNullOrEmpty(textBox2.Text)) && (!String.IsNullOrEmpty(textBox1.Text)))
            {


                 cgpa_num = (float)Convert.ToDouble(textBox1.Text);
                 credit_num = (float)Convert.ToDouble(textBox2.Text);

                cg.Add(cgpa_num);
                cr.Add(credit_num);


                textBox1.ResetText();
                textBox2.ResetText();
            }
            else
            {
                textBox1.ResetText();
                textBox2.ResetText();

                MessageBox.Show(
                    "data is not entered completely",
                    "hello",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    ); return;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {


            richTextBox1.ResetText();
            for (int i = 0; i < cg.Count; i++)
            {
                //Console.WriteLine((cg[i])*(cr[i]));
                //this.textBox5.Text += (cg[i]) * (cr[i]);
                //richTextBox1
                this.richTextBox1.Text += i+1 + "\t " + (cg[i]) + " \t" + (cr[i]) + "\n";
            }

            bool isEmpty = !cg.Any();
            if (isEmpty)
            {
                MessageBox.Show(
                    //exyz.Message,
                    "no data to show",
                    "hello",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    ); return;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        float up_total;
        float down_total;
        float actual_cg;
        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.ResetText();
            textBox4.ResetText();
            bool isEmpty = !cg.Any();
            if (isEmpty)
            {
                MessageBox.Show(
                    //exyz.Message,
                    "no data to calculate",
                    "hello",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    ); return;
            }
            up_total = 0;
            down_total = 0;

            //richTextBox1.ResetText();
            for (int i = 0; i < cg.Count; i++)
            {
                up_total = up_total + ((cg[i]) * (cr[i]));
                down_total = down_total + (cr[i]);

                //this.richTextBox1.Text += i + 1 + "\t " + (cg[i]) + " \t" + (cr[i]) + "\n";
            }
            actual_cg = up_total/down_total;
            this.textBox5.Text += actual_cg;
            this.textBox4.Text += down_total;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        int del_num;
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                del_num = (int)Convert.ToDouble(textBox3.Text);
            }
            catch(Exception exyz)
            {
                //this.richTextBox2.Text= exyz.Message;
                MessageBox.Show(
                    //exyz.Message,
                    "the text box is empty",
                    "hello",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    ); return;
            }
            try
            {
                cg.RemoveAt(del_num-1);
                cr.RemoveAt(del_num-1);

                
            }
            catch
            {
                MessageBox.Show(
                    "this number doesn't exist in the list",
                    "hello",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    ); return;

            }
            textBox3.ResetText();
            MessageBox.Show(
                    "the data is deleted",
                    "hello",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    ); return;

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool isEmpty = !cg.Any();
            if (isEmpty)
            {
                richTextBox1.ResetText();
                textBox5.ResetText();
                textBox4.ResetText();

                MessageBox.Show(
                    //exyz.Message,
                    "everything is already empty",
                    "hello",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    ); return;
            }
            richTextBox1.ResetText();
            textBox5.ResetText();
            textBox4.ResetText();
            cg.Clear();
            cr.Clear();

            MessageBox.Show(
                    //exyz.Message,
                    "all data is reseted",
                    "hello",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    ); return;
        }
    }
}


public class CGPA_cal
{
    public float GPA { get; set; }
    public float credit { get; set; }
}


//future probabbal update
//Add Calculated CGPA, credit and clear all previous

//created by @janakmallik