namespace Cars55.Workers
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            positionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personaBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            Addbt = new ToolStripButton();
            EditBt = new ToolStripButton();
            DelBt = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            //
            // dataGridView1
            //
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, positionDataGridViewTextBoxColumn, salesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = personaBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(768, 376);
            dataGridView1.TabIndex = 0;
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
            // surnameDataGridViewTextBoxColumn
            //
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            //
            // positionDataGridViewTextBoxColumn
            //
            positionDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            //
            // salesDataGridViewTextBoxColumn
            //
            salesDataGridViewTextBoxColumn.DataPropertyName = "Продажи";
            salesDataGridViewTextBoxColumn.HeaderText = "Продажи";
            salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            //
            // personaBindingSource
            //
            personaBindingSource.DataSource = typeof(Models.Persona);
            //
            // toolStrip1
            //
            toolStrip1.Items.AddRange(new ToolStripItem[] { Addbt, EditBt, DelBt });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(768, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            //
            // Addbt
            //
            Addbt.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Addbt.Name = "Addbt";
            Addbt.Size = new Size(63, 22);
            Addbt.Text = "Добавить";
            Addbt.Click += Addbt_Click;
            //
            // EditBt
            //
            EditBt.DisplayStyle = ToolStripItemDisplayStyle.Text;
            EditBt.Name = "EditBt";
            EditBt.Size = new Size(65, 22);
            EditBt.Text = "Изменить";
            EditBt.Click += EditBt_Click;
            //
            // DelBt
            //
            DelBt.DisplayStyle = ToolStripItemDisplayStyle.Text;
            DelBt.Name = "DelBt";
            DelBt.Size = new Size(55, 22);
            DelBt.Text = "Удалить";
            DelBt.Click += DelBt_Click;
            //
            // Form3
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 401);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "Form3";
            Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private BindingSource personaBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton Addbt;
        private ToolStripButton EditBt;
        private ToolStripButton DelBt;
    }
}
