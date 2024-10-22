using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM.BussinesLogic;
using System.Xml.Linq;
using SM.BussinessLogic;
using SM.DataAccess;
using SM.Entity;

namespace SM.View
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }
        public void UpdateGrid()
        {
            dgvSupplier.DataSource = SupplierBL.Instance.SelectAll();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm form1 = new MenuForm();
            form1.Show();
            this.Hide();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id = 0;
            string _name = txtName.Text.Trim();
            string _phone = txtphone.Text.Trim();
            string _email = txtEmail.Text.Trim();
            string _address = txtaddress.Text.Trim();

            if (string.IsNullOrEmpty(_name))
            {
                errorProvider1.SetError(txtName, "NOMBRE NECESARIO");
                return;
            }
            errorProvider1.Clear();

            Supplier entity = new Supplier()
            {
                name = _name,
                phone = _phone,
                email = _email,
                address = _address
            };

            if (id == 0)
            {
                if (SupplierBL.Instance.Insert(entity))
                {
                    MessageBox.Show("La categoría se añadió correctamente", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                entity.supplierID = id;
                if (SupplierBL.Instance.Update(entity))
                {
                    MessageBox.Show("La categoría se modificó correctamente", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }

            UpdateGrid();
        }
    }
}
