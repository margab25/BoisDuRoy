namespace BoisDuRoy_Margaux_Louison.Forms
{
    partial class ViewUpdateFunctions
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
            this.err_nomFonction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_nomFonction = new System.Windows.Forms.TextBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // err_nomFonction
            // 
            this.err_nomFonction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.err_nomFonction.AutoSize = true;
            this.err_nomFonction.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_nomFonction.ForeColor = System.Drawing.Color.Red;
            this.err_nomFonction.Location = new System.Drawing.Point(42, 127);
            this.err_nomFonction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.err_nomFonction.Name = "err_nomFonction";
            this.err_nomFonction.Size = new System.Drawing.Size(93, 20);
            this.err_nomFonction.TabIndex = 30;
            this.err_nomFonction.Text = "Champ vide";
            this.err_nomFonction.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nom fonction";
            // 
            // tbx_nomFonction
            // 
            this.tbx_nomFonction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_nomFonction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_nomFonction.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nomFonction.Location = new System.Drawing.Point(45, 104);
            this.tbx_nomFonction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_nomFonction.Name = "tbx_nomFonction";
            this.tbx_nomFonction.Size = new System.Drawing.Size(265, 20);
            this.tbx_nomFonction.TabIndex = 28;
            // 
            // btn_modify
            // 
            this.btn_modify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_modify.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_modify.FlatAppearance.BorderSize = 0;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify.ForeColor = System.Drawing.Color.White;
            this.btn_modify.Location = new System.Drawing.Point(45, 158);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(104, 32);
            this.btn_modify.TabIndex = 31;
            this.btn_modify.Text = "MODIFIER";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewUpdateFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 520);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.err_nomFonction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_nomFonction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewUpdateFunctions";
            this.Text = "ViewUpdateFuntions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label err_nomFonction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_nomFonction;
        private System.Windows.Forms.Button btn_modify;
    }
}