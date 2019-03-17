using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            string password = tbPassword.Text;
            bool valid = true;

            labelPasswordRule1.ForeColor = Color.Red;
            labelPasswordRule2.ForeColor = Color.Red;
            labelPasswordRule3.ForeColor = Color.Red;
            labelPasswordRule4.ForeColor = Color.Red;

            if (PasswordAdvisor.PasswordLengthValid(password))
            {
                labelPasswordRule1.ForeColor = Color.Black;
            }
            else
            {
                valid = false;
            }

            if (PasswordAdvisor.PasswordFirstLastCharacterValid(password))
            {
                labelPasswordRule2.ForeColor = Color.Black;
            }
            else
            {
                valid = false;
            }

            if (PasswordAdvisor.PasswordDigitValid(password))
            {
                labelPasswordRule3.ForeColor = Color.Black;
            }
            else
            {
                valid = false;
            }

            if (PasswordAdvisor.PasswordLettersNumbersValid(password))
            {
                labelPasswordRule4.ForeColor = Color.Black;
            }
            else
            {
                valid = false;
            }

            labelIsValid.Visible = valid ? true : false;
        }
    }
}
