namespace WizardDemo
{
    partial class ZuordnungDialog
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
            this.components = new System.ComponentModel.Container();
            this.columnInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.columnInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.columnInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // columnInfoDataGridView
            // 
            this.columnInfoDataGridView.AutoGenerateColumns = false;
            this.columnInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.columnInfoDataGridView.DataSource = this.columnInfoBindingSource;
            this.columnInfoDataGridView.Location = new System.Drawing.Point(12, 12);
            this.columnInfoDataGridView.Name = "columnInfoDataGridView";
            this.columnInfoDataGridView.Size = new System.Drawing.Size(345, 220);
            this.columnInfoDataGridView.TabIndex = 1;
            // 
            // columnInfoBindingSource
            // 
            this.columnInfoBindingSource.DataSource = typeof(WizardDemo.Models.ColumnInfo);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SourceName";
            this.dataGridViewTextBoxColumn1.HeaderText = "SourceName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DestinationName";
            this.dataGridViewTextBoxColumn2.HeaderText = "DestinationName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Keep";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Keep";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(201, 293);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(282, 293);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Abbrechen";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-16, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 10);
            this.label1.TabIndex = 4;
            // 
            // ZuordnungDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.columnInfoDataGridView);
            this.Name = "ZuordnungDialog";
            this.Text = "ZuordnungDialog";
            ((System.ComponentModel.ISupportInitialize)(this.columnInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource columnInfoBindingSource;
        private System.Windows.Forms.DataGridView columnInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
    }
}