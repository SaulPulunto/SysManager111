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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm form1 = new CategoryForm();
            form1.Show();
            this.Hide();

        }

        private void btnProType_Click(object sender, EventArgs e)
        {
            ProductTypeForm form1 = new ProductTypeForm();
            form1.Show();
            this.Hide();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            {
                RoleForm form1 = new RoleForm();
                form1.Show();
                this.Hide();
            }
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            BrandForm form1 = new BrandForm();
            form1.Show();
            this.Hide();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm form1 = new SupplierForm();
            form1.Show();
            this.Hide();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm form1 = new UsersForm();
            form1.Show();
            this.Hide();
        }
    }
}
