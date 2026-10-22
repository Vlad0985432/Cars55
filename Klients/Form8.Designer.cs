namespace Cars55.Klients
{
    partial class Form8
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
            txtName = new TextBox();
            txtNumber = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Имя";
            //
            // txtName
            //
            txtName.Location = new Point(12, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.TabIndex = 2;
            label2.Text = "Телефон";
            //
            // txtNumber
            //
            txtNumber.Location = new Point(12, 82);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(200, 23);
            txtNumber.TabIndex = 3;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(12, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить клиента";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // Form8
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 170);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtNumber);
            Controls.Add(btnAdd);
            Name = "Form8";
            Text = "Клиент";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtNumber;
        private Button btnAdd;
    }
}
