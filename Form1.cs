using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        class Person
        {
            public string Name
            {
                get;
                set;
            }
            public string eMail
            {
                get;
                set;
            }
            public float phoneNumber
            {
                get;
                set;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int name = 0;
            name = listBox1.SelectedIndex;

            switch (name)
            {
                case 0: textBox1.Text = "Stew Bertke"; textBox2.Text = "bertke.tyler@greatoaks.com"; textBox3.Text = "513-612-7057"; break;
                case 1: textBox1.Text = "Michael Knox"; textBox2.Text = "michaelknox74@yahoo.com"; textBox3.Text = "513-666-6666"; break;
                case 2: textBox1.Text = "Will Beinke"; textBox2.Text = "william.beinke@greatoaks.com"; textBox3.Text = "513-420-6969"; break;
            }
        }
    }
}
