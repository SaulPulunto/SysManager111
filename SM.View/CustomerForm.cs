using SM.BussinessLogic;
using SM.Entity;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            UpdateGrid();
        }
        public void UpdateGrid()
        {
            dgvCustomer.DataSource = CustomerBL.Instance.SelectAll();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            {
                int id = 0;
                string _name = txtname.Text.Trim();
                string _lastname = txtlastname.Text.Trim();
                string _phone = txtphone.Text.Trim();

                if (string.IsNullOrEmpty(_name))
                {
                    errorProvider1.SetError(txtname, "NOMBRE NECESARIO");
                    return;
                }
                errorProvider1.Clear();

                Customer entity = new Customer()
                {
                    name = _name,
                    lastname = _lastname,
                    phone = _phone,
                };

                if (id == 0)
                {
                    if (CustomerBL.Instance.Insert(entity))
                    {
                        MessageBox.Show("El cliente se añadió correctamente", "Confirmación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    entity.customerID = id;
                    if (CustomerBL.Instance.Update(entity))
                    {
                        MessageBox.Show("El cliente se modificó correctamente", "Confirmación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                UpdateGrid();
            }
        }
    }
}
