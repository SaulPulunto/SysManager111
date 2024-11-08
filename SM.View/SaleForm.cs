using SM.BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM.View
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
            UpdateGrid();
        }
        public void UpdateGrid()
        {
            dgvSale.DataSource = SaleBL.Instance.SelectAll();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm form1 = new MenuForm();
            form1.Show();
            this.Hide();
        }
        private void RoleForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
