using BD.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;

namespace BD
{
    public partial class Form2 : Form
    {
        IUsersRepository usersRepository;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RegistrationController new_user = new RegistrationController();
            //new_user.Registration(textBox1.Text, textBox2.Text);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            usersRepository = new UsersRepository();
            dataGridView.DataSource = usersRepository.GetUsers();

        }
    }
}
