namespace SM.View
{
    partial class SaleForm
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
            btnMenu = new Button();
            btnAgregar = new Button();
            dgvSale = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            txtcliente = new TextBox();
            txtProducto = new TextBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            btnPagar = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dgvSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Location = new Point(908, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(116, 29);
            btnMenu.TabIndex = 35;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Location = new Point(677, 101);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvSale
            // 
            dgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSale.Location = new Point(437, 189);
            dgvSale.Name = "dgvSale";
            dgvSale.RowHeadersWidth = 51;
            dgvSale.Size = new Size(572, 169);
            dgvSale.TabIndex = 31;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 123);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 36;
            label1.Text = "Cliente";
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(147, 120);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(237, 27);
            txtcliente.TabIndex = 37;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(147, 189);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(237, 27);
            txtProducto.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 192);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 39;
            label2.Text = "Producto";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(147, 266);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(133, 27);
            numericUpDown1.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(665, 424);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 41;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(771, 424);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 42;
            label4.Text = "Total:";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = SystemColors.ActiveCaption;
            btnPagar.Location = new Point(437, 424);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(170, 47);
            btnPagar.TabIndex = 43;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(33, 329);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 29);
            progressBar1.TabIndex = 44;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(259, 329);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(125, 29);
            progressBar2.TabIndex = 45;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1036, 500);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(btnPagar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(txtProducto);
            Controls.Add(txtcliente);
            Controls.Add(label1);
            Controls.Add(btnMenu);
            Controls.Add(btnAgregar);
            Controls.Add(dgvSale);
            Name = "SaleForm";
            Text = "SaleForm";
            ((System.ComponentModel.ISupportInitialize)dgvSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private Button btnAgregar;
        private DataGridView dgvSale;
        private ErrorProvider errorProvider1;
        private Label label2;
        private TextBox txtProducto;
        private TextBox txtcliente;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button btnPagar;
        private Label label4;
        private Label label3;
        private ProgressBar progressBar2;
        private ProgressBar progressBar1;
    }
}