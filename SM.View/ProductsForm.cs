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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm form1 = new MenuForm();
            form1.Show();
            this.Hide();
        }
        public void UpdateGrid()
        {
            dgvProducts.DataSource = ProductsBL.Instance.SelectAll();
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string _ProductsName = txtproductName.Text.Trim();
                string _descripcion = txtDescription.Text.Trim();
                decimal _price = decimal.Parse(txtPrecio.Text.Trim());


                if (string.IsNullOrEmpty(_ProductsName))
                {
                    errorProvider1.SetError(txtproductName, "NOMBRE NECESARIO");
                    return;
                }
                errorProvider1.Clear();

                Products entity = new Products()
                {
                    categoryID = int.Parse(txtcategoryID.Text.ToString()),
                    brandID = int.Parse(txtbrandID.Text.ToString()),
                    productTypeID = int.Parse(txtProductType.Text.ToString()),
                    productName = _ProductsName,
                    description = _descripcion,
                    price = _price
                };

                if (ProductsBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Productto registrado correctamente", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateGrid();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el Producto", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de los datos: " + ex.Message);
            }
        }
    }

}
