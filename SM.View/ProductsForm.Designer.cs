namespace SM.View
{
    partial class ProductsForm
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
            components = new System.ComponentModel.Container();
            txtbrandID = new TextBox();
            btnMenu = new Button();
            btnInsert = new Button();
            label7 = new Label();
            txtDescription = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtproductName = new TextBox();
            txtProductType = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtcategoryID = new TextBox();
            dgvProducts = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtPrecio = new TextBox();
            txtProduct = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtbrandID
            // 
            txtbrandID.Location = new Point(156, 231);
            txtbrandID.Name = "txtbrandID";
            txtbrandID.Size = new Size(192, 27);
            txtbrandID.TabIndex = 44;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Location = new Point(908, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(116, 29);
            btnMenu.TabIndex = 43;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(656, 120);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 40;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 385);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 37;
            label7.Text = "Descripcion";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(156, 382);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(192, 27);
            txtDescription.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 335);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 35;
            label6.Text = "Nombre Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 284);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 34;
            label5.Text = "Tpo Producto ID";
            // 
            // txtproductName
            // 
            txtproductName.Location = new Point(156, 335);
            txtproductName.Name = "txtproductName";
            txtproductName.Size = new Size(192, 27);
            txtproductName.TabIndex = 33;
            // 
            // txtProductType
            // 
            txtProductType.Location = new Point(156, 281);
            txtProductType.Name = "txtProductType";
            txtProductType.Size = new Size(192, 27);
            txtProductType.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 234);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 31;
            label4.Text = "MarcaID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 179);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 30;
            label3.Text = "CategoryID";
            // 
            // txtcategoryID
            // 
            txtcategoryID.Location = new Point(156, 176);
            txtcategoryID.Name = "txtcategoryID";
            txtcategoryID.Size = new Size(192, 27);
            txtcategoryID.TabIndex = 29;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(409, 197);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(573, 285);
            dgvProducts.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 437);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 27;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 124);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 26;
            label1.Text = "ProductoID";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(156, 434);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(192, 27);
            txtPrecio.TabIndex = 25;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(156, 120);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(192, 27);
            txtProduct.TabIndex = 24;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1036, 500);
            Controls.Add(txtbrandID);
            Controls.Add(btnMenu);
            Controls.Add(btnInsert);
            Controls.Add(label7);
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtproductName);
            Controls.Add(txtProductType);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtcategoryID);
            Controls.Add(dgvProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(txtProduct);
            Name = "ProductsForm";
            Text = "ProductsForm";
            //Load += ProductsForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbrandID;
        private Button btnMenu;
        private TextBox txttelefono;
        private TextBox txtaddress;
        private Button btnInsert;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtDescription;
        private Label label6;
        private Label label5;
        private TextBox txtproductName;
        private TextBox txtProductType;
        private Label label4;
        private Label label3;
        private TextBox txtcategoryID;
        private DataGridView dgvProducts;
        private Label label2;
        private Label label1;
        private TextBox txtPrecio;
        private TextBox txtProduct;
        private ErrorProvider errorProvider1;
    }
}