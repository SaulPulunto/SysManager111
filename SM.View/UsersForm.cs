using SM.BussinesLogic;
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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            UpdateGrid();
        }
        public void UpdateGrid()
        {
            dgvLogForm.DataSource = UsersBL.Instance.SelectAll();
        }
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm form1 = new MenuForm();
            form1.Show();
            this.Hide();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                string _name = txtName.Text.Trim();
                string _lastname = txtLastName.Text.Trim();
                string _email = txtEmail.Text.Trim();
                string _contra = txtContra.Text.Trim();
                string _address = txtaddress.Text.Trim();
                string _phone = txttelefono.Text.Trim();

                if (string.IsNullOrEmpty(_name))
                {
                    errorProvider1.SetError(txtName, "NOMBRE NECESARIO");
                    return;
                }
                errorProvider1.Clear();

                Users entity = new Users()
                {
                    roleID = int.Parse(txtRoleID.Text.Trim()),
                    municipalityID = int.Parse(txtMunicipioID.Text.ToString()),
                    name = _name,
                    LastName = _lastname,
                    Email = _email,
                    Password = _contra,
                    address = _address,
                    phone = _phone,
                };

                if (UsersBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Usuario registrado correctamente", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateGrid();
                    //ClearForm();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de los datos: " + ex.Message);
            }
        }
        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
