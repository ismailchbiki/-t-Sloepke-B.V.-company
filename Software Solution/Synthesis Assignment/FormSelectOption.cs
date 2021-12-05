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
    public partial class FormSelectOption : Form
    {
        public FormSelectOption()
        {
            InitializeComponent();
        }

        private void FormSelectOption_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            login.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormInventory inventory = new FormInventory();

            inventory.Show();
            this.Hide();
        }

        private void buttonBoats_Click(object sender, EventArgs e)
        {
            FormBoats boats = new FormBoats();

            boats.Show();
            this.Hide();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            FormItems items = new FormItems();

            items.Show();
            this.Hide();
        }
    }
}
