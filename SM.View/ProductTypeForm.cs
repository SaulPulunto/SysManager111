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
using System.Xml.Linq;
namespace SM.View
{
    public partial class ProductTypeForm : Form
    {
        public ProductTypeForm()
        {
            InitializeComponent();
        }
        public void UpdateGrid()
        {
            dgvProType.DataSource = ProductTypeBL.Instance.SelectAll();
        }
        private void btnMenu_Click(object sender, EventArgs e)

        {
            MenuForm form1 = new MenuForm();
            form1.Show();
            this.Hide();
        }

        private void ProductTypeForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id = 0;
            string _name = txtProductType.Text.Trim();

            if (string.IsNullOrEmpty(_name))
            {
                errorProvider1.SetError(txtProductType, "NOMBRE NECESARIO");
                return;
            }
            errorProvider1.Clear();

            ProductType entity = new ProductType()
            {
                type = _name
            };

            if (id == 0)
            {
                if (ProductTypeBL.Instance.Insert(entity))
                {
                    MessageBox.Show("La categoría se añadió correctamente", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                entity.productTypeID = id;
                if (ProductTypeBL.Instance.Update(entity))
                {
                    MessageBox.Show("La categoría se modificó correctamente", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             
            }
            UpdateGrid();
        }
    }
}
