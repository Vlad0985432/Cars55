namespace Cars55.Klients
{
    partial class Form4
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
            dgvKlients = new DataGridView();
            klientBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKlients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klientBindingSource).BeginInit();
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
            tsbEdit.Size = new Size(65, 22);
            tsbEdit.Text = "Изменить";
            tsbEdit.Click += tsbEdit_Click;
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
            lblStatus.Size = new Size(64, 17);
            lblStatus.Text = "Клиенты 0";
            //
            // dgvKlients
            //
            dgvKlients.AutoGenerateColumns = false;
            dgvKlients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKlients.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, numberDataGridViewTextBoxColumn });
            dgvKlients.DataSource = klientBindingSource;
            dgvKlients.Location = new Point(12, 28);
            dgvKlients.Name = "dgvKlients";
            dgvKlients.Size = new Size(884, 397);
            dgvKlients.TabIndex = 2;
            //
            // klientBindingSource
            //
            klientBindingSource.DataSource = typeof(Models.Klient);
            //
            // idDataGridViewTextBoxColumn
            //
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            //
            // nameDataGridViewTextBoxColumn
            //
            nameDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            //
            // numberDataGridViewTextBoxColumn
            //
            numberDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            numberDataGridViewTextBoxColumn.HeaderText = "Телефон";
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            //
            // Form4
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 450);
            Controls.Add(dgvKlients);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Form4";
            Text = "Клиенты";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKlients).EndInit();
            ((System.ComponentModel.ISupportInitialize)klientBindingSource).EndInit();
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
        private DataGridView dgvKlients;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private BindingSource klientBindingSource;
    }
}
