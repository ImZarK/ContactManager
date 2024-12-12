namespace ContactManager
{
    partial class FormUpdateContact
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
            this.textOldPhone = new System.Windows.Forms.TextBox();
            this.txtNewPhone = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textOldPhone
            // 
            this.textOldPhone.Location = new System.Drawing.Point(679, 262);
            this.textOldPhone.Name = "textOldPhone";
            this.textOldPhone.Size = new System.Drawing.Size(185, 20);
            this.textOldPhone.TabIndex = 0;
            this.textOldPhone.Text = "Numero de telefono antiguo";
            this.textOldPhone.TextChanged += new System.EventHandler(this.textOldPhone_TextChanged);
            // 
            // txtNewPhone
            // 
            this.txtNewPhone.Location = new System.Drawing.Point(679, 317);
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.Size = new System.Drawing.Size(185, 20);
            this.txtNewPhone.TabIndex = 1;
            this.txtNewPhone.Text = "Numero de telefono nuevo";
            this.txtNewPhone.TextChanged += new System.EventHandler(this.txtNewPhone_TextChanged);
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(679, 368);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(185, 20);
            this.txtNewName.TabIndex = 2;
            this.txtNewName.Text = "Nuevo nombre";
            this.txtNewName.TextChanged += new System.EventHandler(this.txtNewName_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(730, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormUpdateContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 841);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.txtNewPhone);
            this.Controls.Add(this.textOldPhone);
            this.Name = "FormUpdateContact";
            this.Text = "FormUpdateContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textOldPhone;
        private System.Windows.Forms.TextBox txtNewPhone;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button btnUpdate;
    }
}