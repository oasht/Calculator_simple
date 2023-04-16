using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            tb_res.Enabled = false;

        }

        private void bt_plus_Click(object sender, EventArgs e)
        {
            try
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"click.wav");
                player.Play();
                tb_res.Enabled = true;
                lb_sign.Text = "+";
                double one = double.Parse(tb_1.Text);
                double two = double.Parse(tb_2.Text);
                double res = one + two;
                tb_res.Text = res.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); Clear_tables(); }

        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"click.wav");
                player.Play();
                tb_res.Enabled = true;
                lb_sign.Text = "-";
                double one = double.Parse(tb_1.Text);
                double two = double.Parse(tb_2.Text);
                double res = one - two;
                tb_res.Text = res.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); Clear_tables(); }


        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"click.wav");
                player.Play();
                double res = 0;

                tb_res.Enabled = true;
                lb_sign.Text = "/";
                double one = double.Parse(tb_1.Text);
                double two = double.Parse(tb_2.Text);
                res = one / two;
                if (two != 0)
                    tb_res.Text = res.ToString(); 
                else
                {
                MessageBox.Show("Divide by zero exception", "Error", MessageBoxButtons.OK);
                Clear_tables();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); Clear_tables(); }
            

        }

        private void bt_mult_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"click.wav");
                player.Play();
                tb_res.Enabled = true;
                lb_sign.Text = "*";
                double one = double.Parse(tb_1.Text);
                double two = double.Parse(tb_2.Text);
                double res = one * two;

                tb_res.Text = res.ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); Clear_tables(); }


        }
        public void Clear_tables()
        {
            tb_1.Text = "";
            tb_2.Text = "";
            tb_res.Text = "";
            lb_sign.Text = "";
            tb_res.Enabled = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"button.wav");
            player.Play();
            Clear_tables();
        }
    }
}
