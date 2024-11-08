using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SM.BussinessLogic;
using SM.DataAccess;
using SM.Entity;
using SM.View.Repo;
using System.Globalization;
using SM.BussinesLogic;


namespace SM.View
{
    public partial class FormPurchase : Form
    {
        private List<Purchase> _purchases = new List<Purchase>();
        public FormPurchase()
        {
            InitializeComponent();

            // Otros componentes...

            this.textBoxProduct.Leave += new System.EventHandler(this.textBoxProduct_Leave);



        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {

            UpdateGrid();


            RepositorySup dt = new RepositorySup();


            List<Supplier> suppliers = dt.GetSuppliers();


            List<string> proveedores = suppliers.Select(s => s.name).ToList();


            AutoCompleteStringCollection autoCompleteProveedores = new AutoCompleteStringCollection();
            autoCompleteProveedores.AddRange(proveedores.ToArray());

            textBoxSupllier.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxSupllier.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxSupllier.AutoCompleteCustomSource = autoCompleteProveedores;

            UpdateGrid();


            List<Products> pro = dt.GetProducts();


            List<string> pros = pro.Select(s => s.productName).ToList();


            AutoCompleteStringCollection autoCompleteProducts = new AutoCompleteStringCollection();
            autoCompleteProducts.AddRange(pros.ToArray());

            textBoxProduct.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxProduct.AutoCompleteCustomSource = autoCompleteProducts;





        }


        private void textBoxProduct_Leave(object sender, EventArgs e)

        {
            RepositorySup dt = new RepositorySup();
            List<Products> pro = dt.SelectAll();
            string selectedProductName = textBoxProduct.Text;
            Products selectedProduct = pro.FirstOrDefault(p => p.productName.Equals(selectedProductName, StringComparison.OrdinalIgnoreCase));


            if (selectedProduct != null)
            {
                CultureInfo culture = new CultureInfo("es-SV");
                decimal price = selectedProduct.price.ToDecimal();
                textBoxPrice.Text = price.ToString("C", culture);

                int quantity = (int)numericUpDown1.Value; decimal subtotal = price * quantity;
                textBoxSubtotal.Text = subtotal.ToString("C", culture);/// Mostrar el precio en formato de moneda
            }
            else
            {
                textBoxPrice.Text = string.Empty; // Limpiar el campo si no se encuentra el producto
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            RepositorySup dt = new RepositorySup();
            List<Products> pro = dt.SelectAll();
            string selectedProductName = textBoxProduct.Text;
            Products selectedProduct = pro.FirstOrDefault(p => p.productName.Equals(selectedProductName, StringComparison.OrdinalIgnoreCase));

            if (selectedProduct != null)
            {
                // Convertir SqlMoney a decimal para usar ToString("C")
                decimal price = selectedProduct.price.ToDecimal();

                // Calcular y actualizar el subtotal basado en la cantidad en numericUpDown1
                CultureInfo culture = new CultureInfo("es-SV");
                int quantity = (int)numericUpDown1.Value;
                decimal subtotal = price * quantity;
                textBoxSubtotal.Text = subtotal.ToString("C", culture);
            }
        }


        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepositorySup dt = new RepositorySup();
            List<Products> pro = dt.SelectAll();
            List<Supplier> suppliers = dt.Select(); // Asegúrate de obtener la lista de proveedores también
            string selectedProductName = textBoxProduct.Text;
            Products selectedProduct = pro.FirstOrDefault(p => p.productName.Equals(selectedProductName, StringComparison.OrdinalIgnoreCase));
            if (selectedProduct != null)
            {
                int Cantidad = (int)numericUpDown1.Value;
                decimal totalPurchase = selectedProduct.price.ToDecimal() * Cantidad;
                string supplierName = textBoxSupllier.Text.Trim(); // Asegúrate de que el nombre del TextBox es correcto

                // Buscar supplierID usando el nombre del proveedor
                // Buscar supplierID usando el nombre del proveedor
                Supplier selectedSupplier = suppliers.FirstOrDefault(s => s.name.Equals(supplierName, StringComparison.OrdinalIgnoreCase));
                if (selectedSupplier == null)
                {
                    MessageBox.Show("El nombre del proveedor no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                int supID = selectedSupplier.supplierID;

                Purchase entity = new Purchase()
                {

                    supplierID = supID,
                    productsID = selectedProduct.productsID,
                    quantity = Cantidad,
                    totalpurchase = totalPurchase
                };

                var existingPurchase = _purchases.FirstOrDefault(x => x.productsID == entity.productsID);
                if (existingPurchase != null)
                {
                    existingPurchase.quantity += entity.quantity;
                    existingPurchase.totalpurchase += entity.totalpurchase;
                }
                else
                {
                    _purchases.Add(entity);
                }

                // Crear una lista anónima para el DataGridView con los nombres de los productos y proveedores
                var displayList = _purchases.Select(p => new
                {

                    Proveedor = suppliers.FirstOrDefault(sups => sups.supplierID == p.supplierID)?.name, // Obtener el nombre del proveedor
                    Producto = pro.FirstOrDefault(prod => prod.productsID == p.productsID)?.productName, // Obtener el nombre del producto
                    Cantidad = p.quantity,
                    Total = p.totalpurchase.ToString("F2")
                }).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = displayList;

                // Calcular el total de todas las compras
                CultureInfo culture = new CultureInfo("es-SV");
                decimal total = _purchases.Sum(x => x.totalpurchase);
                labelTotal.Text = total.ToString("C", culture);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (_purchases.Count > 0)
                {
                    // Crear una nueva instancia de compra principal
                    var purchaseDetail = new PurchaseDet()
                    {
                        Date = DateTime.Now,
                        Total = _purchases.Sum(x => x.totalpurchase)
                    };

                    // Crear una lista para los detalles de la compra
                    List<Purchase> purchaseDetailsList = new List<Purchase>();

                    foreach (var item in _purchases)
                    {
                        purchaseDetailsList.Add(new Purchase()
                        {
                            productsID = item.productsID,
                            supplierID = item.supplierID,
                            quantity = item.quantity,
                            totalpurchase = item.totalpurchase
                        });
                    }

                    // Confirmar con el usuario
                    DialogResult dr = MessageBox.Show("¿Desea procesar la compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        // Llamar al método de la capa de lógica de negocios para insertar la compra y sus detalles
                        bool result = PurchaseBL.Instance.Insert(purchaseDetail, purchaseDetailsList);

                        if (result)
                        {
                            MessageBox.Show("¡La compra se procesó con éxito!");
                           
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al procesar la compra.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay elementos en el carrito de compras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            UpdateGrid();

        }


      

        public void UpdateGrid()
        {
            try
            {
                // Obtener la lista de compras desde la lógica de negocios
                var purchases = PurchaseBL.Instance.SelectAll();

                // Crear una lista anónima para formatear correctamente los valores
                var displayList = purchases.Select(p => new
                {
                    ID = p.purchaseID,
                    Proveedor = p.supplierID,
                    Productos = p.productsID,
                    Cantidad = p.quantity,
                    Total = p.totalpurchase.ToString("F2") // Formatear el subtotal a dos decimales
                }).ToList();
                
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = displayList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la tabla: " + ex.Message);
            }
        }

    }



}
