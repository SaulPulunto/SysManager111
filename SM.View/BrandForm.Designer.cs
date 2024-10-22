namespace SM.View
{
    partial class BrandForm
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
            label2 = new Label();
            label1 = new Label();
            btnInsert = new Button();
            dgvBrand = new DataGridView();
            txtBrand = new TextBox();
            txtBrandID = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Location = new Point(908, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(116, 29);
            btnMenu.TabIndex = 19;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 338);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 18;
            label2.Text = "Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 249);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(672, 147);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 16;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dgvBrand
            // 
            dgvBrand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrand.Location = new Point(436, 191);
            dgvBrand.Name = "dgvBrand";
            dgvBrand.RowHeadersWidth = 51;
            dgvBrand.Size = new Size(573, 285);
            dgvBrand.TabIndex = 15;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(116, 335);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(252, 27);
            txtBrand.TabIndex = 14;
            // 
            // txtBrandID
            // 
            txtBrandID.Location = new Point(116, 249);
            txtBrandID.Name = "txtBrandID";
            txtBrandID.Size = new Size(252, 27);
            txtBrandID.TabIndex = 13;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // BrandForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1036, 500);
            Controls.Add(btnMenu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInsert);
            Controls.Add(dgvBrand);
            Controls.Add(txtBrand);
            Controls.Add(txtBrandID);
            Name = "BrandForm";
            Text = "BrandForm";
            Load += BrandForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private Label label2;
        private Label label1;
        private Button btnInsert;
        private DataGridView dgvBrand;
        private TextBox txtBrand;
        private TextBox txtBrandID;
        private ErrorProvider errorProvider1;
    }
}