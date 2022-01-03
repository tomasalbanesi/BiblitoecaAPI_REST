namespace HttpClient_WinFromsTest
{
    partial class FrmCategoryList
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
            this.dgvCategoriesList = new System.Windows.Forms.DataGridView();
            this.txtIdCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriesList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategoriesList
            // 
            this.dgvCategoriesList.AllowUserToAddRows = false;
            this.dgvCategoriesList.AllowUserToDeleteRows = false;
            this.dgvCategoriesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdCategory,
            this.txtName});
            this.dgvCategoriesList.Location = new System.Drawing.Point(12, 44);
            this.dgvCategoriesList.Name = "dgvCategoriesList";
            this.dgvCategoriesList.ReadOnly = true;
            this.dgvCategoriesList.RowHeadersWidth = 51;
            this.dgvCategoriesList.RowTemplate.Height = 29;
            this.dgvCategoriesList.Size = new System.Drawing.Size(821, 387);
            this.dgvCategoriesList.TabIndex = 0;
            // 
            // txtIdCategory
            // 
            this.txtIdCategory.HeaderText = "IdCategory";
            this.txtIdCategory.MinimumWidth = 6;
            this.txtIdCategory.Name = "txtIdCategory";
            this.txtIdCategory.ReadOnly = true;
            this.txtIdCategory.Width = 125;
            // 
            // txtName
            // 
            this.txtName.HeaderText = "Name";
            this.txtName.MinimumWidth = 400;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Categories:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(683, 9);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 29);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmCategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 443);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCategoriesList);
            this.Name = "FrmCategoryList";
            this.Text = "FrmCategoryList";
            this.Load += new System.EventHandler(this.FrmCategoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoriesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.Button btnActualizar;
    }
}