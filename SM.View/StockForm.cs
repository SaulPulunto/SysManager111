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
    public partial class StockForm : Form
    {
        public StockForm()
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
            dgvStock.DataSource = StockBL.Instance.SelectAll();
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string _stockID = txtStockID.Text.Trim();
                string _stockstatusID = txtstockstatusID.Text.Trim();
                string _productsID = txtproductsID.Text.Trim();
                string _branchID = txtbranchID.Text.Trim();
                string _quantity = txtquantity.Text.Trim();


                if (string.IsNullOrEmpty(_quantity))
                {
                    errorProvider1.SetError(txtquantity, "CANTIDAD NECESARIO");
                    return;
                }
                errorProvider1.Clear();

                Stock entity = new Stock()
                {
                    stockID = int.Parse(txtStockID.Text.ToString()),
                    stockstatusID = int.Parse(txtstockstatusID.Text.ToString()),
                    productsID = int.Parse(txtproductsID.Text.ToString()),
                    branchID = int.Parse(txtbranchID.Text.ToString()),
                    quantity = int.Parse(txtquantity.Text.ToString())
                };

                if (StockBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Stock registrado correctamente", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateGrid();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el Stock", "Error",
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
