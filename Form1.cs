using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double grossIncome, netIncome, totalDeduc;
        String empId, empName;
        private void deduction_calc()
        {
            try
            {
                double advance, phic, ssi, d1, d2, d3, d4;

                advance = double.Parse(txtpcadvance.Text);
                phic = double.Parse(txtpphic.Text);
                ssi = double.Parse(txtppagibig.Text);
                d1 = double.Parse(txtpdeduct1.Text);
                d2 = double.Parse(txtpdeduct2.Text);
                d3 = double.Parse(txtpdeduct3.Text);
                d4 = double.Parse(txtpdeduct4.Text);


                totalDeduc = advance + phic + ssi + d1 + d2 + d3 + d4;
                txtpdeducttot.Text = totalDeduc.ToString();

                netIncome = grossIncome - totalDeduc;
                txtpnetincome.Text = netIncome.ToString();
            }
            catch
            {

            }

        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            empId = textBox3.Text;
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {
            double rateWage, othrs, otRate, ot, holpay;
            rateWage = double.Parse(label21.Text);

            holpay = double.Parse(label23.Text);

            if (textBox9.Text == "" || textBox9.Text == "0" || textBox10.Text == "" || textBox10.Text == "0")
            {
                textBox9.Text = "0";


            }
            else
            {

                othrs = double.Parse(textBox9.Text);
                otRate = double.Parse(textBox10.Text);
                ot = othrs * otRate;
                label22.Text = ot.ToString();

                grossIncome = rateWage + ot + holpay;
                label24.Text = grossIncome.ToString();

            }

            netIncome = grossIncome - double.Parse(txtpdeducttot.Text);
            txtpnetincome.Text = netIncome.ToString();
        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {
            double ratePerday, rateWage, ot, holpay, holdays;
            rateWage = double.Parse(label21.Text);
            ot = double.Parse(label22.Text);


            if (textBox9.Text == "" || textBox9.Text == "0")
            {
                textBox9.Text = "0";
            }
            else
            {
                holdays = double.Parse(textBox11.Text);
                ratePerday = double.Parse(textBox1.Text);
                holpay = holdays * ratePerday;
                label23.Text = holpay.ToString();
                grossIncome = rateWage + ot + holpay;
                label24.Text = grossIncome.ToString();

            }

            netIncome = grossIncome - double.Parse(txtpdeducttot.Text);
            txtpnetincome.Text = netIncome.ToString();
        }

        private void Txtpcadvance_TextChanged(object sender, EventArgs e)
        {
            deduction_calc();
        }

        private void Txtpphic_TextChanged(object sender, EventArgs e)
        {
            deduction_calc();

        }

        private void Txtppagibig_TextChanged(object sender, EventArgs e)
        {
            deduction_calc();
        }

        private void Txtpdeduct1_TextChanged(object sender, EventArgs e)
        {
            deduction_calc();
        }

        private void Txtpdeduct2_TextChanged(object sender, EventArgs e)
        {
            deduction_calc();
        }

        private void Txtpdeduct3_TextChanged(object sender, EventArgs e)
        {
            deduction_calc();
        }

        private void Txtpdeduct4_TextChanged(object sender, EventArgs e)
        {
            deduction_calc();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login111DataSet1.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.login111DataSet1.login);
            // TODO: This line of code loads data into the 'login111DataSet1.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.login111DataSet1.login);
                   
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            loginBindingSource.MovePrevious();
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            loginBindingSource.AddNew();
            loginTableAdapter.Insert(textBox3.Text, textBox4.Text, label24.Text, txtpdeducttot.Text, txtpnetincome.Text);
            loginTableAdapter.Fill(login111DataSet1.login);
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
            loginBindingSource.MoveNext();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try {
                this.Validate();
                this.loginBindingSource.EndEdit();
                this.loginTableAdapter.Update(this.login111DataSet1.login);
                MessageBox.Show("Your information is recorded");
            }
  
            catch(Exception exc) {

                MessageBox.Show(exc.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            loginBindingSource.RemoveCurrent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.ResetText();
            textBox1.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            
            txtpcadvance.Text = "0";
            txtpphic.Text = "0";
            txtppagibig.Text = "0";
            txtpdeductname1.Clear();
            txtpdeductname2.Clear();
            txtpdeductname3.Clear();
            txtpdeductname4.Clear();
            txtpdeduct1.Text = "0";
            txtpdeduct2.Text = "0";
            txtpdeduct3.Text = "0";
            txtpdeduct4.Text = "0";
            txtpdeducttot.Text = "0";
            txtpnetincome.Text = "0";
            label21.Text = "0";
            label22.Text = "0";
            label23.Text = "0";
            label24.Text = "0";








        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String current = comboBox1.SelectedText;


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.loginBindingSource.EndEdit();
                this.loginTableAdapter.Update(this.login111DataSet1.login);
                MessageBox.Show("Your information is recorded");
            }

            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        private void Txtpdeducttot_TextChanged(object sender, EventArgs e)
        {
            deduction_calc();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            empName = textBox4.Text;
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            double ratePerday, workDays, rateWage, ot, holpay;


            ot = double.Parse(label22.Text);
            holpay = double.Parse(label23.Text);

            if (textBox8.Text == "" || textBox8.Text == "0")
            {
                textBox8.Text = "0";


            }
            else
            {
                ratePerday = double.Parse(textBox1.Text);
                workDays = double.Parse(textBox8.Text);
                rateWage = ratePerday * workDays;
                label21.Text = rateWage.ToString();

                grossIncome = rateWage + ot + holpay;
                label24.Text = grossIncome.ToString();

            }
            netIncome = grossIncome - double.Parse(txtpdeducttot.Text);
            txtpnetincome.Text = netIncome.ToString();
        }
    }
}
