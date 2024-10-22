namespace SM.View
{
    partial class SupplierForm
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
            dgvSupplier = new DataGridView();
            txtName = new TextBox();
            txtsupplierIDID = new TextBox();
            txtphone = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtaddress = new TextBox();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Location = new Point(908, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(116, 29);
            btnMenu.TabIndex = 26;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 225);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 25;
            label2.Text = "Nombre Completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 165);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 24;
            label1.Text = "ID";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(694, 141);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 23;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dgvSupplier
            // 
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(436, 191);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.Size = new Size(573, 285);
            dgvSupplier.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Location = new Point(164, 222);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 27);
            txtName.TabIndex = 21;
            // 
            // txtsupplierIDID
            // 
            txtsupplierIDID.Location = new Point(164, 162);
            txtsupplierIDID.Name = "txtsupplierIDID";
            txtsupplierIDID.Size = new Size(252, 27);
            txtsupplierIDID.TabIndex = 20;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(164, 281);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(252, 27);
            txtphone.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 284);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 28;
            label3.Text = "Telefono";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(164, 337);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 27);
            txtEmail.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 340);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 30;
            label4.Text = "Email";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(164, 397);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(252, 27);
            txtaddress.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 400);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 32;
            label5.Text = "Direccion";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1036, 500);
            Controls.Add(label5);
            Controls.Add(txtaddress);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtphone);
            Controls.Add(btnMenu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInsert);
            Controls.Add(dgvSupplier);
            Controls.Add(txtName);
            Controls.Add(txtsupplierIDID);
            Name = "SupplierForm";
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private Label label2;
        private Label label1;
        private Button btnInsert;
        private DataGridView dgvSupplier;
        private TextBox txtName;
        private TextBox txtsupplierIDID;
        private TextBox txtphone;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtaddress;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}