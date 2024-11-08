namespace SM.View
{
    partial class CustomerForm
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
            label2 = new Label();
            label1 = new Label();
            btnMenu = new Button();
            label3 = new Label();
            label4 = new Label();
            btnInsert = new Button();
            dgvCustomer = new DataGridView();
            txtname = new TextBox();
            txtcustomerID = new TextBox();
            txtlastname = new TextBox();
            txtphone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-85, 311);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 18;
            label2.Text = "Rol";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-85, 222);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Location = new Point(888, 18);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(116, 29);
            btnMenu.TabIndex = 25;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 234);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 24;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 169);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 23;
            label4.Text = "ID";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(677, 141);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 22;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(416, 197);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(573, 285);
            dgvCustomer.TabIndex = 21;
            // 
            // txtname
            // 
            txtname.Location = new Point(116, 231);
            txtname.Name = "txtname";
            txtname.Size = new Size(252, 27);
            txtname.TabIndex = 20;
            // 
            // txtcustomerID
            // 
            txtcustomerID.Location = new Point(116, 166);
            txtcustomerID.Name = "txtcustomerID";
            txtcustomerID.Size = new Size(252, 27);
            txtcustomerID.TabIndex = 19;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(116, 300);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(252, 27);
            txtlastname.TabIndex = 26;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(116, 375);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(252, 27);
            txtphone.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 303);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 28;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 378);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 29;
            label6.Text = "Telefono";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1036, 500);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtphone);
            Controls.Add(txtlastname);
            Controls.Add(btnMenu);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnInsert);
            Controls.Add(dgvCustomer);
            Controls.Add(txtname);
            Controls.Add(txtcustomerID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button btnMenu;
        private Label label3;
        private Label label4;
        private Button btnInsert;
        private DataGridView dgvCustomer;
        private TextBox txtname;
        private TextBox txtcustomerID;
        private TextBox txtlastname;
        private TextBox txtphone;
        private Label label5;
        private Label label6;
        private ErrorProvider errorProvider1;
    }
}