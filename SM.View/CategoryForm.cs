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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        public void UpdateGrid()
        {
            dvvCategory.DataSource = CategoryBL.Instance.SelectAll();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm form1 = new MenuForm();
            form1.Show();
            this.Hide();

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id = 0;
            string _name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(_name))
            {
                errorProvider1.SetError(txtName, "NOMBRE NECESARIO");
                return;
            }
            errorProvider1.Clear();

            Category entity = new Category()
            {
                CategoryName = _name
            };

            if (id == 0)
            {
                if (CategoryBL.Instance.Insert(entity))
                {
                    MessageBox.Show("La categoría se añadió correctamente", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                entity.categoryID = id;
                if (CategoryBL.Instance.Update(entity))
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