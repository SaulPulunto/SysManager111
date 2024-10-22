namespace SM.View
{
    partial class CategoryForm
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
            txtCategoryID = new TextBox();
            txtName = new TextBox();
            dvvCategory = new DataGridView();
            btnInsert = new Button();
            label1 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dvvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(158, 234);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(168, 27);
            txtCategoryID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 307);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 27);
            txtName.TabIndex = 1;
            // 
            // dvvCategory
            // 
            dvvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvvCategory.Location = new Point(436, 191);
            dvvCategory.Name = "dvvCategory";
            dvvCategory.RowHeadersWidth = 51;
            dvvCategory.Size = new Size(573, 285);
            dvvCategory.TabIndex = 2;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(685, 137);
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
            label1.Location = new Point(57, 237);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 310);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
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
            btnMenu.TabIndex = 7;
            btnMenu.Text = "Volver al Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1036, 500);
            Controls.Add(btnMenu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInsert);
            Controls.Add(dvvCategory);
            Controls.Add(txtName);
            Controls.Add(txtCategoryID);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoryID;
        private TextBox txtName;
        private DataGridView dvvCategory;
        private Button btnInsert;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
        private Button btnMenu;
    }
}