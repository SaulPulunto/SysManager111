namespace SM.View
{
    partial class dgvLog
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
            txtUsers = new TextBox();
            txtContra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvLogForm = new DataGridView();
            txtRoleID = new TextBox();
            label3 = new Label();
            txtMuniciID = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnInsert = new Button();
            errorProvider1 = new ErrorProvider(components);
            txtaddress = new TextBox();
            txttelefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLogForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtUsers
            // 
            txtUsers.Location = new Point(160, 33);
            txtUsers.Name = "txtUsers";
            txtUsers.Size = new Size(192, 27);
            txtUsers.TabIndex = 0;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(160, 333);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(192, 27);
            txtContra.TabIndex = 1;
            txtContra.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 36);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 336);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Contra";
            // 
            // dgvLogForm
            // 
            dgvLogForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogForm.Location = new Point(436, 191);
            dgvLogForm.Name = "dgvLogForm";
            dgvLogForm.RowHeadersWidth = 51;
            dgvLogForm.Size = new Size(573, 285);
            dgvLogForm.TabIndex = 4;
            // 
            // txtRoleID
            // 
            txtRoleID.Location = new Point(160, 76);
            txtRoleID.Name = "txtRoleID";
            txtRoleID.Size = new Size(192, 27);
            txtRoleID.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 79);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 6;
            label3.Text = "Rol";
            // 
            // txtMuniciID
            // 
            txtMuniciID.Location = new Point(160, 125);
            txtMuniciID.Name = "txtMuniciID";
            txtMuniciID.Size = new Size(192, 27);
            txtMuniciID.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 128);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Municipio";
            // 
            // txtName
            // 
            txtName.Location = new Point(160, 174);
            txtName.Name = "txtName";
            txtName.Size = new Size(192, 27);
            txtName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(160, 225);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(192, 27);
            txtLastName.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 177);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 11;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 228);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 12;
            label6.Text = "Apellido";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 279);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 27);
            txtEmail.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 282);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 389);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 16;
            label8.Text = "Direccion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 443);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 18;
            label9.Text = "Telefono";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(683, 114);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 19;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(160, 386);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(192, 27);
            txtaddress.TabIndex = 20;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(160, 440);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(192, 27);
            txttelefono.TabIndex = 21;
            // 
            // dgvLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1036, 500);
            Controls.Add(txttelefono);
            Controls.Add(txtaddress);
            Controls.Add(btnInsert);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(txtMuniciID);
            Controls.Add(label3);
            Controls.Add(txtRoleID);
            Controls.Add(dgvLogForm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContra);
            Controls.Add(txtUsers);
            Name = "dgvLog";
            Text = "LogForm";
            ((System.ComponentModel.ISupportInitialize)dgvLogForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsers;
        private TextBox txtContra;
        private Label label1;
        private Label label2;
        private DataGridView dgvLogForm;
        private TextBox txtRoleID;
        private Label label3;
        private TextBox txtMuniciID;
        private Label label4;
        private TextBox txtName;
        private TextBox txtLastName;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnInsert;
        private ErrorProvider errorProvider1;
        private TextBox txtaddress;
        private TextBox txttelefono;
    }
}