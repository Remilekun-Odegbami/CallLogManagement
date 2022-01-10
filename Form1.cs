using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallLogManagement
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(textName.Text.Length > 0)
                {
                    textSurname.Focus();
                } 
                else
                {
                textName.Focus();

                }
            }
        }

        private void textSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textSurname.Text.Length > 0)
                {
                    textBox3.Focus();
                }
                else
                {
                    textSurname.Focus();

                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox3.Text.Length > 0)
                {
                    textAddress.Focus();              
                }
                else
                {
                    textBox3.Focus();

                }
            }
        }

        
        private void statusBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (statusBox.SelectedIndex != -1)
                {
                    dateTimePicker1.Focus();
                }
                else
                {
                    statusBox.Focus();

                }
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dateTimePicker1.Text.Length > 0)
                {
                    textTime.Focus();
                }
                else
                {
                    dateTimePicker1.Focus();

                }
            }
        }

        private void textTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textTime.Text.Length > 0)
                {
                    textDuration.Focus();
                }
                else
                {
                    textTime.Focus();

                }
            }
        }

        private void textDuration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textDuration.Text.Length > 0)
                {
                    textRemarks.Focus();
                }
                else
                {
                    textDuration.Focus();

                }
            }
        }

    }
}
