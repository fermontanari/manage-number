using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageNumber.Presentation
{
    public partial class ManageNumberForm : Form
    {
        public ManageNumberForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;

            try
            {
                ManageNumberService.ManageNumberServiceClient client = new ManageNumberService.ManageNumberServiceClient();
                client.Checkin(number);
                client.Close();
                MessageBox.Show(String.Format("Number '{0}' added.", number));
                textBox1.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;

            try
            {
                ManageNumberService.ManageNumberServiceClient client = new ManageNumberService.ManageNumberServiceClient();
                var value = client.Checkout(number);
                client.Close();
                
                MessageBox.Show(String.Format("Number '{0}' fee value of R${1}.", number, value));
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ManageNumberService.ManageNumberServiceClient client = new ManageNumberService.ManageNumberServiceClient();
                var value = client.VagasRestantes();
                client.Close();

                MessageBox.Show(String.Format("Numbers left: {0}.", value));
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}