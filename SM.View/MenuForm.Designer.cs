namespace SM.View
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCategory = new Button();
            btnRole = new Button();
            btnProType = new Button();
            btnBrand = new Button();
            btnSupplier = new Button();
            btnSalida = new Button();
            btnUsers = new Button();
            btnProducts = new Button();
            btnSale = new Button();
            btnCustomer = new Button();
            SuspendLayout();
            // 
            // btnCategory
            // 
            btnCategory.BackColor = SystemColors.ActiveCaption;
            btnCategory.Location = new Point(134, 76);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(208, 50);
            btnCategory.TabIndex = 0;
            btnCategory.Text = "Categoria";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnRole
            // 
            btnRole.BackColor = SystemColors.ActiveCaption;
            btnRole.Location = new Point(505, 76);
            btnRole.Name = "btnRole";
            btnRole.Size = new Size(208, 50);
            btnRole.TabIndex = 1;
            btnRole.Text = "Rol";
            btnRole.UseVisualStyleBackColor = false;
            btnRole.Click += btnRole_Click;
            // 
            // btnProType
            // 
            btnProType.BackColor = SystemColors.ActiveCaption;
            btnProType.Location = new Point(134, 152);
            btnProType.Name = "btnProType";
            btnProType.Size = new Size(208, 50);
            btnProType.TabIndex = 2;
            btnProType.Text = "Tipo de Producto";
            btnProType.UseVisualStyleBackColor = false;
            btnProType.Click += btnProType_Click;
            // 
            // btnBrand
            // 
            btnBrand.BackColor = SystemColors.ActiveCaption;
            btnBrand.Location = new Point(134, 236);
            btnBrand.Name = "btnBrand";
            btnBrand.Size = new Size(208, 50);
            btnBrand.TabIndex = 3;
            btnBrand.Text = "Marca";
            btnBrand.UseVisualStyleBackColor = false;
            btnBrand.Click += btnBrand_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = SystemColors.ActiveCaption;
            btnSupplier.Location = new Point(505, 152);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(208, 50);
            btnSupplier.TabIndex = 4;
            btnSupplier.Text = "Proveedor";
            btnSupplier.UseVisualStyleBackColor = false;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // btnSalida
            // 
            btnSalida.BackColor = SystemColors.ActiveCaption;
            btnSalida.Location = new Point(764, 12);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(112, 49);
            btnSalida.TabIndex = 5;
            btnSalida.Text = "Salir";
            btnSalida.UseVisualStyleBackColor = false;
            btnSalida.Click += btnSalida_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = SystemColors.ActiveCaption;
            btnUsers.Location = new Point(505, 236);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(208, 50);
            btnUsers.TabIndex = 6;
            btnUsers.Text = "Usuarios";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.ActiveCaption;
            btnProducts.Location = new Point(134, 313);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(208, 50);
            btnProducts.TabIndex = 7;
            btnProducts.Text = "Productos";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSale
            // 
            btnSale.BackColor = SystemColors.ActiveCaption;
            btnSale.Location = new Point(505, 313);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(208, 50);
            btnSale.TabIndex = 8;
            btnSale.Text = "Ventas";
            btnSale.UseVisualStyleBackColor = false;
            btnSale.Click += btnSale_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = SystemColors.ActiveCaption;
            btnCustomer.Location = new Point(134, 389);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(208, 50);
            btnCustomer.TabIndex = 9;
            btnCustomer.Text = "Cliente";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(888, 547);
            ControlBox = false;
            Controls.Add(btnCustomer);
            Controls.Add(btnSale);
            Controls.Add(btnProducts);
            Controls.Add(btnUsers);
            Controls.Add(btnSalida);
            Controls.Add(btnSupplier);
            Controls.Add(btnBrand);
            Controls.Add(btnProType);
            Controls.Add(btnRole);
            Controls.Add(btnCategory);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategory;
        private Button btnRole;
        private Button btnProType;
        private Button btnBrand;
        private Button btnSupplier;
        private Button btnSalida;
        private Button btnUsers;
        private Button btnProducts;
        private Button btnSale;
        private Button btnCustomer;
    }
}