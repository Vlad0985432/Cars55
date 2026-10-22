namespace Cars55.Sales
{
    partial class Form10
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
            label4 = new Label();
            label5 = new Label();
            cmbKlient = new ComboBox();
            cmbCar = new ComboBox();
            cmbSotrudnik = new ComboBox();
            dtpData = new DateTimePicker();
            numSumma = new NumericUpDown();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numSumma).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Клиент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Автомобиль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Дата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Сумма";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 236);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 8;
            label5.Text = "Сотрудник";
            // 
            // cmbKlient
            // 
            cmbKlient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKlient.Location = new Point(12, 32);
            cmbKlient.Name = "cmbKlient";
            cmbKlient.Size = new Size(260, 23);
            cmbKlient.TabIndex = 1;
            // 
            // cmbCar
            // 
            cmbCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCar.Location = new Point(12, 87);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(260, 23);
            cmbCar.TabIndex = 3;
            cmbCar.SelectedIndexChanged += cmbCar_SelectedIndexChanged;
            // 
            // cmbSotrudnik
            // 
            cmbSotrudnik.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSotrudnik.Location = new Point(12, 269);
            cmbSotrudnik.Name = "cmbSotrudnik";
            cmbSotrudnik.Size = new Size(260, 23);
            cmbSotrudnik.TabIndex = 9;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(12, 142);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(260, 23);
            dtpData.TabIndex = 5;
            // 
            // numSumma
            // 
            numSumma.Location = new Point(12, 197);
            numSumma.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numSumma.Name = "numSumma";
            numSumma.Size = new Size(260, 23);
            numSumma.TabIndex = 7;
            numSumma.ThousandsSeparator = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(260, 30);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Добавить продажу";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 373);
            Controls.Add(label1);
            Controls.Add(cmbKlient);
            Controls.Add(label2);
            Controls.Add(cmbCar);
            Controls.Add(label3);
            Controls.Add(dtpData);
            Controls.Add(label4);
            Controls.Add(numSumma);
            Controls.Add(label5);
            Controls.Add(cmbSotrudnik);
            Controls.Add(btnAdd);
            Name = "Form10";
            Text = "Продажа";
            ((System.ComponentModel.ISupportInitialize)numSumma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cmbKlient;
        private ComboBox cmbCar;
        private DateTimePicker dtpData;
        private NumericUpDown numSumma;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbSotrudnik;
    }
}
