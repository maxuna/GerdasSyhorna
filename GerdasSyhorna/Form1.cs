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
            //FormEmployee formEmployee = new FormEmployee();
            //formEmployee.Show();

            Order order = new Order();
            Dictionary<int, Tuple<
           // order.CreateOrder(1, DateTime.Now, )
            
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var database = Database.OpenConnection(Resources.connectionString);
           
            //testar om användaren finns i databasen
            var userLogin = database.SP_Userslogin(textBoxUsername.Text, textBoxPassword.Text);

            userLogin = userLogin.ToList();

            //användarnamnet eller lösenordet får bara stämma överens med en rad i databasen
            if (userLogin.Count == 1)
            {
                var userinfo = userLogin[0].IsEmployee ? database.SP_UserEmployee(userLogin[0].UserId) : database.SP_UserCustomer(userLogin[0].UserId);

                if (MessageBox.Show("Välkommen " + userinfo.First().Firstname + " " + userinfo.First().Lastname) == DialogResult.OK)
                {
                    if (!userLogin[0].IsEmployee)
                    {
                        FormCustomer formCustomer = new FormCustomer();
                        formCustomer.Show();
                    }
                    else
                    {
                        FormEmployee formEmployee = new FormEmployee();
                        formEmployee.Show();
                    }
                    this.Hide();
                }
                
            }

            else
            {
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                MessageBox.Show("fel användarnamn/lösenord");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
