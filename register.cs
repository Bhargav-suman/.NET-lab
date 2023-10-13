using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MDIdemo
{
    public partial class register : Form
    {

        public register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            // Check the length of the input
            /*  if (inputText.Length > 3 && inputText.Length < 16)
              {
                  // Input is valid; you can choose to enable a button or provide a message
                  // For example, enabling a Save button:
                  // saveButton.Enabled = true;
                  button1.Enabled = true;
              }
              else
              {
                  MessageBox.Show("Input must be between 4 and 15 characters in length.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 3 && textBox1.Text.Length > 16)
            {
                MessageBox.Show("Input must be between 4 and 15 characters in length.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (IsEmailValid(textBox2.Text) != true)
            {
                MessageBox.Show("Invalid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("password is not matched to confirm password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Registration successful", "congratulations!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Other");
        }

        private bool IsEmailValid(string email)
        {
            // Define a regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
