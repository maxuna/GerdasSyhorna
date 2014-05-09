using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simple.Data;
using System.IO;



namespace GerdasSyhorna
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
   
            InitializeComponent();
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var database = Database.OpenConnection(Resources.connectionString);

            //testar om användaren finns i databasen
            var userLogin = database.Users_login(textBoxUsername.Text, textBoxPassword.Text);

            userLogin = userLogin.ToList();

            if (userLogin.Count == 1)
            {
                var userinfo = database.User_Customer(userLogin[0].UserId);

                if (MessageBox.Show("Välkommen " + userinfo.First().Firstname + " " + userinfo.First().Lastname) == DialogResult.OK)
                {
                    this.Close();
                }
                
            }

            else
            {
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                MessageBox.Show("fel användarnamn/lösenord");
            }

        }
    }
}
