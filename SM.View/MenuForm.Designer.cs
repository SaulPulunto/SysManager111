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
            SuspendLayout();
            // 
            // btnCategory
            // 
            btnCategory.BackColor = SystemColors.ActiveCaption;
            btnCategory.Location = new Point(134, 129);
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
            btnRole.Location = new Point(460, 129);
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
            btnProType.Location = new Point(134, 217);
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
            btnBrand.Location = new Point(134, 313);
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
            btnSupplier.Location = new Point(460, 217);
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
            btnUsers.Location = new Point(460, 313);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(208, 50);
            btnUsers.TabIndex = 6;
            btnUsers.Text = "Usuarios";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(888, 547);
            ControlBox = false;
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
    }
}