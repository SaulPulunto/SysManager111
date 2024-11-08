namespace SM.View
{
    partial class FormPurchase
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelTotal = new Label();
            textBoxSupllier = new TextBox();
            textBoxProduct = new TextBox();
            dataGridView1 = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            textBoxPrice = new TextBox();
            textBoxSubtotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "PROVEEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 115);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "PRODUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(627, 413);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "TOTAL";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(709, 417);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(15, 15);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "A";
            // 
            // textBoxSupllier
            // 
            textBoxSupllier.Location = new Point(76, 38);
            textBoxSupllier.Name = "textBoxSupllier";
            textBoxSupllier.Size = new Size(200, 23);
            textBoxSupllier.TabIndex = 4;
            // 
            // textBoxProduct
            // 
            textBoxProduct.Location = new Point(76, 133);
            textBoxProduct.Name = "textBoxProduct";
            textBoxProduct.Size = new Size(200, 23);
            textBoxProduct.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(548, 150);
            dataGridView1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(363, 204);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(72, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(76, 177);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(200, 23);
            textBoxPrice.TabIndex = 5;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.Location = new Point(76, 203);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.Size = new Size(99, 23);
            textBoxSubtotal.TabIndex = 5;
            textBoxSubtotal.TextChanged += textBoxPrice_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(520, 191);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(672, 287);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxSubtotal);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxProduct);
            Controls.Add(textBoxSupllier);
            Controls.Add(labelTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPurchase";
            Text = "FormPurchase";
            Load += FormPurchase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelTotal;
        private TextBox textBoxSupllier;
        private TextBox textBoxProduct;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private TextBox textBoxPrice;
        private TextBox textBoxSubtotal;
        private Button button1;
        private Button button2;
    }
}