namespace WinForms2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_chislo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_chislo
            // 
            this.btn_chislo.Location = new System.Drawing.Point(246, 323);
            this.btn_chislo.Name = "btn_chislo";
            this.btn_chislo.Size = new System.Drawing.Size(280, 62);
            this.btn_chislo.TabIndex = 0;
            this.btn_chislo.Text = "УГАДАЙ ЧИСЛО";
            this.btn_chislo.UseVisualStyleBackColor = true;
            this.btn_chislo.Click += new System.EventHandler(this.btn_chislo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_chislo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_chislo;
    }
}