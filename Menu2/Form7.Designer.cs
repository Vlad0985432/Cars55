namespace Cars55.Menu2
{
    partial class Form7
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
            btnKatalog = new Button();
            btnPersonal = new Button();
            btnKlient = new Button();
            btnSales = new Button();
            SuspendLayout();
            // 
            // btnKatalog
            // 
            btnKatalog.Location = new Point(52, 26);
            btnKatalog.Name = "btnKatalog";
            btnKatalog.Size = new Size(109, 48);
            btnKatalog.TabIndex = 0;
            btnKatalog.Text = "Каталог";
            btnKatalog.UseVisualStyleBackColor = true;
            btnKatalog.Click += btnKatalog_Click;
            // 
            // btnPersonal
            // 
            btnPersonal.Location = new Point(52, 105);
            btnPersonal.Name = "btnPersonal";
            btnPersonal.Size = new Size(109, 52);
            btnPersonal.TabIndex = 1;
            btnPersonal.Text = "Персонал";
            btnPersonal.UseVisualStyleBackColor = true;
            btnPersonal.Click += btnPersonal_Click;
            // 
            // btnKlient
            // 
            btnKlient.Location = new Point(53, 192);
            btnKlient.Name = "btnKlient";
            btnKlient.Size = new Size(108, 51);
            btnKlient.TabIndex = 2;
            btnKlient.Text = "Клиенты";
            btnKlient.UseVisualStyleBackColor = true;
            btnKlient.Click += btnKlient_Click;
            // 
            // btnSales
            // 
            btnSales.Location = new Point(53, 267);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(108, 51);
            btnSales.TabIndex = 3;
            btnSales.Text = "Продажи";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSales);
            Controls.Add(btnKlient);
            Controls.Add(btnPersonal);
            Controls.Add(btnKatalog);
            Name = "Form7";
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKatalog;
        private Button btnPersonal;
        private Button btnKlient;
        private Button btnSales;
    }
}