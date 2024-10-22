namespace SM.View
{
    partial class RoleForm
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
            btnInsert = new Button();
            dgvRole = new DataGridView();
            txtRole = new TextBox();
            txtRoleID = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRole).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 330);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 11;
            label2.Text = "Rol";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 241);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(668, 135);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dgvRole
            // 
            dgvRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRole.Location = new Point(436, 191);
            dgvRole.Name = "dgvRole";
            dgvRole.RowHeadersWidth = 51;
            dgvRole.Size = new Size(573, 285);
            dgvRole.TabIndex = 8;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(136, 327);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(252, 27);
            txtRole.TabIndex = 7;
            // 
            // txtRoleID
            // 
            txtRoleID.Location = new Point(136, 241);
            txtRoleID.Name = "txtRoleID";
            txtRoleID.Size = new Size(252, 27);
            txtRoleID.TabIndex = 6;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Location = new Point(908, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(116, 29);
            btnMenu.TabIndex = 12;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1036, 500);
            Controls.Add(btnMenu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInsert);
            Controls.Add(dgvRole);
            Controls.Add(txtRole);
            Controls.Add(txtRoleID);
            Name = "RoleForm";
            Text = "RoleForm";
            Load += RoleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRole).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnInsert;
        private DataGridView dgvRole;
        private TextBox txtRole;
        private TextBox txtRoleID;
        private ErrorProvider errorProvider1;
        private Button btnMenu;
    }
}