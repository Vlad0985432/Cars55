namespace Cars55.Sales
{
    partial class Form9
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
            toolStrip1 = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            dgvSales = new DataGridView();
            saleBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            klientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sotrudnikDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            summaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            SuspendLayout();
            //
            // toolStrip1
            //
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbDelete });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(896, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            //
            // tsbAdd
            //
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(63, 22);
            tsbAdd.Text = "Добавить";
            tsbAdd.Click += tsbAdd_Click;
            //
            // tsbEdit
            //
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(58, 22);
            tsbEdit.Text = "Изменить";
            tsbEdit.Click += tsbEdit_Click;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(63, 22);
            tsbAdd.Text = "Добавить";
            tsbAdd.Click += tsbAdd_Click;
            //
            // tsbDelete
            //
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(55, 22);
            tsbDelete.Text = "Удалить";
            tsbDelete.Click += tsbDelete_Click;
            //
            // statusStrip1
            //
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(896, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            //
            // lblStatus
            //
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(74, 17);
            lblStatus.Text = "Продажи 0";
            //
            // dgvSales
            //
            dgvSales.AutoGenerateColumns = false;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, klientDataGridViewTextBoxColumn, carDataGridViewTextBoxColumn, sotrudnikDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, summaDataGridViewTextBoxColumn });
            dgvSales.DataSource = saleBindingSource;
            dgvSales.Location = new Point(12, 28);
            dgvSales.Name = "dgvSales";
            dgvSales.Size = new Size(884, 397);
            dgvSales.TabIndex = 2;
            dgvSales.ReadOnly = true;
            dgvSales.AllowUserToAddRows = false;
            //
            // saleBindingSource
            //
            saleBindingSource.DataSource = typeof(Models.Sale);
            //
            // idDataGridViewTextBoxColumn
            //
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            //
            // klientDataGridViewTextBoxColumn
            //
            klientDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            klientDataGridViewTextBoxColumn.HeaderText = "Клиент";
            klientDataGridViewTextBoxColumn.Name = "klientDataGridViewTextBoxColumn";
            //
            // carDataGridViewTextBoxColumn
            //
            carDataGridViewTextBoxColumn.DataPropertyName = "Автомобиль";
            carDataGridViewTextBoxColumn.HeaderText = "Автомобиль";
            carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            //
            // sotrudnikDataGridViewTextBoxColumn
            //
            sotrudnikDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
            sotrudnikDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            sotrudnikDataGridViewTextBoxColumn.Name = "sotrudnikDataGridViewTextBoxColumn";
            //
            // dataDataGridViewTextBoxColumn
            //
            dataDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            dataDataGridViewTextBoxColumn.HeaderText = "Дата";
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            dataDataGridViewTextBoxColumn.DefaultCellStyle.Format = "d";
            dataDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // summaDataGridViewTextBoxColumn
            //
            summaDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            summaDataGridViewTextBoxColumn.HeaderText = "Сумма";
            summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            summaDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N0";
            summaDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // Form9
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 450);
            Controls.Add(dgvSales);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Form9";
            Text = "Продажи";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbDelete;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private DataGridView dgvSales;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn klientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sotrudnikDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private BindingSource saleBindingSource;
    }
}
