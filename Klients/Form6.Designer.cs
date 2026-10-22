namespace Cars55.Workers
{
    partial class Form6
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
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtFam = new TextBox();
            txtStatus = new TextBox();
            btAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // txtName
            // 
            txtName.Location = new Point(51, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 97);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 177);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Должность";
            // 
            // txtFam
            // 
            txtFam.Location = new Point(51, 126);
            txtFam.Name = "txtFam";
            txtFam.Size = new Size(100, 23);
            txtFam.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(48, 208);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 5;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(59, 354);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(182, 23);
            btAdd.TabIndex = 6;
            btAdd.Text = "Добавить работника";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btAdd);
            Controls.Add(txtStatus);
            Controls.Add(txtFam);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Добавить персонал";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtFam;
        private TextBox txtStatus;
        private Button btAdd;
    }
}
