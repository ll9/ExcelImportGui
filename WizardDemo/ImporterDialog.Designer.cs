namespace WizardDemo
{
    partial class ImporterDialog
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImportWizard = new AeroWizard.WizardControl();
            this.ImportPage = new AeroWizard.WizardPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExcelPathButton = new System.Windows.Forms.Button();
            this.ExcelPathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MappingPage = new AeroWizard.WizardPage();
            this.CustomizeTableButton = new System.Windows.Forms.Button();
            this.ProjectionBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YBox = new System.Windows.Forms.ComboBox();
            this.XBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImportWizard)).BeginInit();
            this.ImportPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MappingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportWizard
            // 
            this.ImportWizard.BackColor = System.Drawing.Color.White;
            this.ImportWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportWizard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportWizard.Location = new System.Drawing.Point(0, 0);
            this.ImportWizard.Name = "ImportWizard";
            this.ImportWizard.Pages.Add(this.ImportPage);
            this.ImportWizard.Pages.Add(this.MappingPage);
            this.ImportWizard.Size = new System.Drawing.Size(484, 450);
            this.ImportWizard.TabIndex = 0;
            this.ImportWizard.Text = "ExcelImport";
            this.ImportWizard.Title = "ExcelImport";
            // 
            // ImportPage
            // 
            this.ImportPage.Controls.Add(this.groupBox1);
            this.ImportPage.Name = "ImportPage";
            this.ImportPage.Size = new System.Drawing.Size(437, 296);
            this.ImportPage.TabIndex = 0;
            this.ImportPage.Text = "Import";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExcelPathButton);
            this.groupBox1.Controls.Add(this.ExcelPathBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Einstellungen Der Excel Verbindung";
            // 
            // ExcelPathButton
            // 
            this.ExcelPathButton.Location = new System.Drawing.Point(272, 73);
            this.ExcelPathButton.Name = "ExcelPathButton";
            this.ExcelPathButton.Size = new System.Drawing.Size(100, 23);
            this.ExcelPathButton.TabIndex = 2;
            this.ExcelPathButton.Text = "Durchsuchen...";
            this.ExcelPathButton.UseVisualStyleBackColor = true;
            this.ExcelPathButton.Click += new System.EventHandler(this.ExcelPathButton_Click);
            // 
            // ExcelPathBox
            // 
            this.ExcelPathBox.Location = new System.Drawing.Point(20, 73);
            this.ExcelPathBox.Name = "ExcelPathBox";
            this.ExcelPathBox.Size = new System.Drawing.Size(215, 23);
            this.ExcelPathBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excel Dateipfad:";
            // 
            // MappingPage
            // 
            this.MappingPage.Controls.Add(this.CustomizeTableButton);
            this.MappingPage.Controls.Add(this.ProjectionBox);
            this.MappingPage.Controls.Add(this.label4);
            this.MappingPage.Controls.Add(this.YBox);
            this.MappingPage.Controls.Add(this.XBox);
            this.MappingPage.Controls.Add(this.label3);
            this.MappingPage.Controls.Add(this.label2);
            this.MappingPage.Name = "MappingPage";
            this.MappingPage.Size = new System.Drawing.Size(437, 296);
            this.MappingPage.TabIndex = 1;
            this.MappingPage.Text = "Mapping";
            // 
            // CustomizeTableButton
            // 
            this.CustomizeTableButton.Location = new System.Drawing.Point(291, 256);
            this.CustomizeTableButton.Name = "CustomizeTableButton";
            this.CustomizeTableButton.Size = new System.Drawing.Size(131, 23);
            this.CustomizeTableButton.TabIndex = 6;
            this.CustomizeTableButton.Text = "Zuordnung anpassen";
            this.CustomizeTableButton.UseVisualStyleBackColor = true;
            this.CustomizeTableButton.Click += new System.EventHandler(this.CustomizeTableButton_Click);
            // 
            // ProjectionBox
            // 
            this.ProjectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectionBox.FormattingEnabled = true;
            this.ProjectionBox.Location = new System.Drawing.Point(166, 124);
            this.ProjectionBox.Name = "ProjectionBox";
            this.ProjectionBox.Size = new System.Drawing.Size(121, 23);
            this.ProjectionBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Projektion";
            // 
            // YBox
            // 
            this.YBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YBox.FormattingEnabled = true;
            this.YBox.Location = new System.Drawing.Point(166, 70);
            this.YBox.Name = "YBox";
            this.YBox.Size = new System.Drawing.Size(121, 23);
            this.YBox.TabIndex = 3;
            // 
            // XBox
            // 
            this.XBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XBox.FormattingEnabled = true;
            this.XBox.Location = new System.Drawing.Point(166, 19);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(121, 23);
            this.XBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y-Koordinate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "X-Koordinate";
            // 
            // ImporterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.ImportWizard);
            this.Name = "ImporterDialog";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImportWizard)).EndInit();
            this.ImportPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MappingPage.ResumeLayout(false);
            this.MappingPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl ImportWizard;
        private AeroWizard.WizardPage Import;
        private AeroWizard.WizardPage Mapping;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ExcelPathButton;
        private System.Windows.Forms.TextBox ExcelPathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProjectionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox YBox;
        private System.Windows.Forms.ComboBox XBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CustomizeTableButton;
        private AeroWizard.WizardPage ImportPage;
        private AeroWizard.WizardPage MappingPage;
    }
}

