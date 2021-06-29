namespace MyFirstApp.ForLoop
{
    partial class frmForLoop
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(270, 166);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 22);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(270, 258);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(261, 22);
            this.txtAge.TabIndex = 8;
            this.txtAge.TextChanged += new System.EventHandler(this.TxtAge_TextChanged);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(270, 122);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(261, 22);
            this.txtStudentId.TabIndex = 7;
            this.txtStudentId.TextChanged += new System.EventHandler(this.TxtStudentId_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(270, 213);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(261, 22);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.TextChanged += new System.EventHandler(this.TxtSurname_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(357, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // frmForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.btnSave);
            this.Name = "frmForLoop";
            this.Text = "frmForLoop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnSave;
    }
}