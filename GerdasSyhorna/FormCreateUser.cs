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
namespace GerdasSyhorna
{
    public partial class FormCreateUser : Form
    {
        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {

#region Passwordvariation Check
            byte containsLetter = 0, containsDigit = 0, containsSymbol = 0, containsUpperLetter = 0;

            foreach (char letter in textBoxPassword.Text)
            {
                if (Char.IsDigit(letter) && containsDigit == 0)
                {
                    containsDigit++;
                }

                else if (Char.IsSymbol(letter) && containsSymbol == 0)
                {
                    containsSymbol++;
                }

                else if (Char.IsLetter(letter) && containsLetter == 0)
                {
                    containsLetter++;
                }

                else if (Char.IsUpper(letter) && containsUpperLetter == 0)
                {
                    containsUpperLetter++;
                }
            }

            if (containsLetter + containsSymbol + containsDigit < 2)
            {
                MessageBox.Show(@"Lösenordet kräver minst två olika teckentyper (t.ex, @, m, 5)");
                return;
            }


#endregion


            if (textBoxPassword.Text.Length < 6)
            {
                MessageBox.Show("Lösenordet måste minst vara 6 tecken långt");
                return;
            }

            
            var textBoxCollection = this.Controls.OfType<TextBox>();
            //kollar om alla textrutor har ifyllda värden
            foreach (var item in textBoxCollection)
            {
                if (item != textBoxEmail && item.Text.Length < 1)
                {
                    MessageBox.Show("Fyll i alla textrutor! (Email behöver inte fyllas i)");
                    return;
                }
            }

            

            var db = Database.OpenConnection(Resources.connectionString);
            db.Users.Insert(Username: textBoxUsername.Text, Password: textBoxPassword.Text, IsEmployee: false);

            int userId = db.Users.Find(db.Users.Username == textBoxUsername.Text).UserId;
            db.Customers.Insert(UserId: userId, Firstname: textBoxFirstname.Text,
                Lastname: textBoxLastname.Text, Address: textBoxAdress.Text, Telephone: textBoxTelephone.Text, Email: textBoxEmail.Text);


            MessageBox.Show("Användarkontot är skapat, nu kan du logga in");
            this.Dispose();
        }

        private void checkBoxShowPw_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = textBoxPassword.UseSystemPasswordChar == true ? 
                textBoxPassword.UseSystemPasswordChar = false : textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
