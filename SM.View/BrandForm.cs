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
    public partial class BrandForm : Form
    {
        int id = 0;
        public BrandForm()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm form1 = new MenuForm();
            form1.Show();
            this.Hide();
        }
        public void UpdateGrid()
        {
            dgvBrand.DataSource = BrandBL.Instance.SelectAll();
        }
        private void BrandForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtBrand.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(txtBrand, "NOMBRE NECESARIO");
                return;
            }
            errorProvider1.Clear();

            Brand entity = new Brand()
            {
                brandName = name
            };

            if (id == 0)
            {
                if (BrandBL.Instance.Insert(entity))
                {
                    MessageBox.Show("La categoría se añadió correctamente", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                entity.brandID = id;
                if (BrandBL.Instance.Update(entity))
                {
                    MessageBox.Show("La categoría se modificó correctamente", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }

            UpdateGrid();
        }
        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
