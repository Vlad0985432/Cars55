namespace Cars55.Katalog
{
    partial class Form5
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
            txtBrand = new TextBox();
            txtModel = new TextBox();
            numPrice = new NumericUpDown();
            btnAdd = new Button();
            label4 = new Label();
            numYear = new NumericUpDown();
            label5 = new Label();
            txtColor = new TextBox();
            label6 = new Label();
            numMileage = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMileage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Марка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Модель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Цена";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(12, 32);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(200, 23);
            txtBrand.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(12, 82);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(200, 23);
            txtModel.TabIndex = 4;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(12, 132);
            numPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 5;
            numPrice.ThousandsSeparator = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 337);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить автомобиль";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 162);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 7;
            label4.Text = "Год";
            // 
            // numYear
            // 
            numYear.Location = new Point(14, 180);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(120, 23);
            numYear.TabIndex = 8;
            numYear.ThousandsSeparator = true;
            numYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 212);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Цвет";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(17, 235);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(195, 23);
            txtColor.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 263);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 11;
            label6.Text = "Пробег";
            // 
            // numMileage
            // 
            numMileage.Location = new Point(20, 281);
            numMileage.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numMileage.Name = "numMileage";
            numMileage.Size = new Size(120, 23);
            numMileage.TabIndex = 12;
            numMileage.ThousandsSeparator = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 379);
            Controls.Add(numMileage);
            Controls.Add(label6);
            Controls.Add(txtColor);
            Controls.Add(label5);
            Controls.Add(numYear);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtBrand);
            Controls.Add(label2);
            Controls.Add(txtModel);
            Controls.Add(label3);
            Controls.Add(numPrice);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление автомобиля";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMileage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBrand;
        private TextBox txtModel;
        private NumericUpDown numPrice;
        private Button btnAdd;
        private Label label4;
        private NumericUpDown numYear;
        private Label label5;
        private TextBox txtColor;
        private Label label6;
        private NumericUpDown numMileage;
    }
}
