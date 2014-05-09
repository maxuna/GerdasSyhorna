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
    public partial class FormCustomer : Form
    {


        public FormCustomer()
        {
            InitializeComponent();



            var database = Database.OpenConnection(Resources.connectionString);

        }

    }
}
