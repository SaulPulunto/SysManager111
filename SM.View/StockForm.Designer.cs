namespace SM.View
{
    partial class StockForm
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
            label5 = new Label();
            txtquantity = new TextBox();
            label4 = new Label();
            txtbranchID = new TextBox();
            label3 = new Label();
            txtproductsID = new TextBox();
            btnMenu = new Button();
            label2 = new Label();
            label1 = new Label();
            btnInsert = new Button();
            dgvStock = new DataGridView();
            txtstockstatusID = new TextBox();
            txtStockID = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 406);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 45;
            label5.Text = "Cantidad";
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(164, 403);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(252, 27);
            txtquantity.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 346);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 43;
            label4.Text = "Sucursal";
            // 
            // txtbranchID
            // 
            txtbranchID.Location = new Point(164, 343);
            txtbranchID.Name = "txtbranchID";
            txtbranchID.Size = new Size(252, 27);
            txtbranchID.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 290);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 41;
            label3.Text = "ProductoID";
            // 
            // txtproductsID
            // 
            txtproductsID.Location = new Point(164, 287);
            txtproductsID.Name = "txtproductsID";
            txtproductsID.Size = new Size(252, 27);
            txtproductsID.TabIndex = 40;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Location = new Point(908, 18);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(116, 29);
            btnMenu.TabIndex = 39;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 231);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 38;
            label2.Text = "Estado Stock ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 171);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 37;
            label1.Text = "StockID";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(694, 147);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 36;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(436, 197);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(573, 285);
            dgvStock.TabIndex = 35;
            // 
            // txtstockstatusID
            // 
            txtstockstatusID.Location = new Point(164, 228);
            txtstockstatusID.Name = "txtstockstatusID";
            txtstockstatusID.Size = new Size(252, 27);
            txtstockstatusID.TabIndex = 34;
            // 
            // txtStockID
            // 
            txtStockID.Location = new Point(164, 168);
            txtStockID.Name = "txtStockID";
            txtStockID.Size = new Size(252, 27);
            txtStockID.TabIndex = 33;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 500);
            Controls.Add(label5);
            Controls.Add(txtquantity);
            Controls.Add(label4);
            Controls.Add(txtbranchID);
            Controls.Add(label3);
            Controls.Add(txtproductsID);
            Controls.Add(btnMenu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInsert);
            Controls.Add(dgvStock);
            Controls.Add(txtstockstatusID);
            Controls.Add(txtStockID);
            Name = "StockForm";
            Text = "StockForm";
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtquantity;
        private Label label4;
        private TextBox txtbranchID;
        private Label label3;
        private TextBox txtproductsID;
        private Button btnMenu;
        private Label label2;
        private Label label1;
        private Button btnInsert;
        private DataGridView dgvStock;
        private TextBox txtstockstatusID;
        private TextBox txtStockID;
        private ErrorProvider errorProvider1;
    }
}