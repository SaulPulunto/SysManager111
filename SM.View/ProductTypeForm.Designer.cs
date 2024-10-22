namespace SM.View
{
    partial class ProductTypeForm
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
            txtProductType = new TextBox();
            txtType = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            dgvProType = new DataGridView();
            btnInsert = new Button();
            label1 = new Label();
            label2 = new Label();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProType).BeginInit();
            SuspendLayout();
            // 
            // txtProductType
            // 
            txtProductType.Location = new Point(188, 227);
            txtProductType.Name = "txtProductType";
            txtProductType.Size = new Size(208, 27);
            txtProductType.TabIndex = 0;
            // 
            // txtType
            // 
            txtType.Location = new Point(188, 295);
            txtType.Name = "txtType";
            txtType.Size = new Size(208, 27);
            txtType.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgvProType
            // 
            dgvProType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProType.Location = new Point(436, 191);
            dgvProType.Name = "dgvProType";
            dgvProType.RowHeadersWidth = 51;
            dgvProType.Size = new Size(573, 285);
            dgvProType.TabIndex = 2;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(672, 142);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 230);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 4;
            label1.Text = "Tipo Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 298);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Location = new Point(908, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(116, 29);
            btnMenu.TabIndex = 8;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // ProductTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1036, 500);
            Controls.Add(btnMenu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInsert);
            Controls.Add(dgvProType);
            Controls.Add(txtType);
            Controls.Add(txtProductType);
            Name = "ProductTypeForm";
            Text = "ProductTypeForm";
            Load += ProductTypeForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductType;
        private TextBox txtType;
        private ErrorProvider errorProvider1;
        private DataGridView dgvProType;
        private Button btnInsert;
        private Label label2;
        private Label label1;
        private Button btnMenu;
    }
}