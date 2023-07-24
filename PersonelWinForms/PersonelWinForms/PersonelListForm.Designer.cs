namespace PersonelWinForms
{
    partial class PersonelListForm
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
            dgvPersonel = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonel
            // 
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonel.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPersonel.Location = new Point(12, 67);
            dgvPersonel.MultiSelect = false;
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.RowTemplate.Height = 25;
            dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonel.Size = new Size(776, 150);
            dgvPersonel.TabIndex = 0;
            // 
            // PersonelListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPersonel);
            Name = "PersonelListForm";
            Text = "Personel Listesi";
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPersonel;
    }
}