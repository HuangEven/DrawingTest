using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingTest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            comboBoxLoginType.Items.AddRange(new object[] { "Drawing","Texting" });
            comboBoxLoginType.SelectedIndex = 0;
            //isValid();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void isValid()
        {
            if (textBoxUserName.Text == "Even"
                && textBoxPassWord.Text == "123456"
                && comboBoxLoginType.Text == "Drawing")
            {
                Program.isValidUser = true;
                Program.isDraw = true;
                //Console.WriteLine("isDraw=true\n");
            }    
            else if (textBoxUserName.Text == "Even"
                && textBoxPassWord.Text == "123456"
                && comboBoxLoginType.Text == "Texting")
            {
                Program.isValidUser = true;
                Program.isText = true;
                //Console.WriteLine("isText=true\n");
            }
            else
                Program.isValidUser = false;
        }

       
        private void buttonOK_Click(object sender, EventArgs e)
        {
            isValid();
            if (Program.isValidUser ==false)
            {
                LoginFail fail = new LoginFail();
                fail.StartPosition = FormStartPosition.CenterParent;
               
                if (fail.ShowDialog() == DialogResult.OK)
                {
                    //this.Close();
                }
              
            }
            else
                this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
