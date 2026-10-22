namespace Cars55
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            toolStrip1 = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            dgvCars = new DataGridView();
            carBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mileageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            SuspendLayout();
            //
            // toolStrip1
            //
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbDelete });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(896, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            //
            // tsbAdd
            //
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(63, 22);
            tsbAdd.Text = "Добавить";
            tsbAdd.Click += tsbAdd_Click;
            //
            // tsbEdit
            //
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(65, 22);
            tsbEdit.Text = "Изменить";
            tsbEdit.Click += tsbEdit_Click;
            //
            // tsbDelete
            //
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
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
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            //
            // lblStatus
            //
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(92, 17);
            lblStatus.Text = "Автомобили 0";
            //
            // dgvCars
            //
            dgvCars.AutoGenerateColumns = false;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, mileageDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dgvCars.DataSource = carBindingSource;
            dgvCars.Location = new Point(12, 28);
            dgvCars.Name = "dgvCars";
            dgvCars.Size = new Size(884, 397);
            dgvCars.TabIndex = 6;
            //
            // carBindingSource
            //
            carBindingSource.DataSource = typeof(Models.Car);
            //
            // idDataGridViewTextBoxColumn
            //
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            //
            // brandDataGridViewTextBoxColumn
            //
            brandDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            brandDataGridViewTextBoxColumn.HeaderText = "Марка";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            //
            // modelDataGridViewTextBoxColumn
            //
            modelDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            //
            // yearDataGridViewTextBoxColumn
            //
            yearDataGridViewTextBoxColumn.DataPropertyName = "Год";
            yearDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            //
            // priceDataGridViewTextBoxColumn
            //
            priceDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            //
            // colorDataGridViewTextBoxColumn
            //
            colorDataGridViewTextBoxColumn.DataPropertyName = "Цвет";
            colorDataGridViewTextBoxColumn.HeaderText = "Цвет";
            colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            //
            // mileageDataGridViewTextBoxColumn
            //
            mileageDataGridViewTextBoxColumn.DataPropertyName = "Пробег";
            mileageDataGridViewTextBoxColumn.HeaderText = "Пробег";
            mileageDataGridViewTextBoxColumn.Name = "mileageDataGridViewTextBoxColumn";
            //
            // statusDataGridViewTextBoxColumn
            //
            statusDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            //
            // Form2
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 450);
            Controls.Add(dgvCars);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Form2";
            Text = "Автомобили";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
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
        private DataGridView dgvCars;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource carBindingSource;
    }
}
