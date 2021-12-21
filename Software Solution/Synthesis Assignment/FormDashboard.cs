using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synthesis_Assignment
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            login.Show();
            this.Hide();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            FormInventory inventory = new FormInventory();

            inventory.Show();
            this.Hide();
        }

        private void buttonAdministration_Click(object sender, EventArgs e)
        {
            FormFindCustomer findCustomer = new FormFindCustomer();

            findCustomer.Show();
            this.Hide();
        }
    }
}
