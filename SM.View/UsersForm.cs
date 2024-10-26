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
    public partial class dgvLog : Form
    {
        public dgvLog()
        {
            InitializeComponent();
            UpdateGrid();
        }
        public void UpdateGrid()
        {
            dgvLogForm.DataSource = UsersBL.Instance.SelectAll();
        }
        public void SupplierForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Users newUser = new Users()
                {
                    name = txtName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    password = txtContra.Text.Trim(),
                    address = txtaddress.Text.Trim(),
                    phone = txttelefono.Text.Trim(),
                    roleID = int.Parse(txtRoleID.Text.Trim()),
                    municipalityID = int.Parse(txtMuniciID.Text.Trim())
                };

                bool isInserted = UsersBL.Instance.Insert(newUser);

                if (isInserted)
                {
                    MessageBox.Show("Usuario insertado exitosamente.");
                    UpdateGrid();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el usuario.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de los datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el usuario: " + ex.Message);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm form1 = new MenuForm();
            form1.Show();
            this.Hide();
        }
    }
}
