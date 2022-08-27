namespace PasswordGenerator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLenght = new System.Windows.Forms.TextBox();
            this.btnGenereteP = new System.Windows.Forms.Button();
            this.lbPasswords = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbFolderNames = new System.Windows.Forms.ComboBox();
            this.txtFolderSelect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number of Characters:";
            // 
            // txtLenght
            // 
            this.txtLenght.Location = new System.Drawing.Point(242, 17);
            this.txtLenght.Margin = new System.Windows.Forms.Padding(5);
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(329, 26);
            this.txtLenght.TabIndex = 1;
            // 
            // btnGenereteP
            // 
            this.btnGenereteP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenereteP.Location = new System.Drawing.Point(24, 97);
            this.btnGenereteP.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenereteP.Name = "btnGenereteP";
            this.btnGenereteP.Size = new System.Drawing.Size(228, 54);
            this.btnGenereteP.TabIndex = 2;
            this.btnGenereteP.Text = "Generete Password";
            this.btnGenereteP.UseVisualStyleBackColor = true;
            this.btnGenereteP.Click += new System.EventHandler(this.btnGenereteP_Click);
            // 
            // lbPasswords
            // 
            this.lbPasswords.FormattingEnabled = true;
            this.lbPasswords.ItemHeight = 20;
            this.lbPasswords.Location = new System.Drawing.Point(260, 97);
            this.lbPasswords.Name = "lbPasswords";
            this.lbPasswords.Size = new System.Drawing.Size(310, 84);
            this.lbPasswords.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(343, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 62);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Password";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbFolderNames
            // 
            this.cmbFolderNames.FormattingEnabled = true;
            this.cmbFolderNames.Location = new System.Drawing.Point(24, 262);
            this.cmbFolderNames.Name = "cmbFolderNames";
            this.cmbFolderNames.Size = new System.Drawing.Size(313, 28);
            this.cmbFolderNames.TabIndex = 6;
            // 
            // txtFolderSelect
            // 
            this.txtFolderSelect.Enabled = false;
            this.txtFolderSelect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFolderSelect.Location = new System.Drawing.Point(24, 403);
            this.txtFolderSelect.Name = "txtFolderSelect";
            this.txtFolderSelect.Size = new System.Drawing.Size(313, 26);
            this.txtFolderSelect.TabIndex = 7;
            this.txtFolderSelect.Text = "Type the file path you want to access";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 364);
            this.Controls.Add(this.txtFolderSelect);
            this.Controls.Add(this.cmbFolderNames);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbPasswords);
            this.Controls.Add(this.btnGenereteP);
            this.Controls.Add(this.txtLenght);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLenght;
        private System.Windows.Forms.Button btnGenereteP;
        private System.Windows.Forms.ListBox lbPasswords;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbFolderNames;
        private System.Windows.Forms.TextBox txtFolderSelect;
    }
}

