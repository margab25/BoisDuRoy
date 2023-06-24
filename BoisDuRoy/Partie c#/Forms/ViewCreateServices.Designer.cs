namespace BoisDuRoy_Margaux_Louison.Forms
{
    partial class ViewCreateServices
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
            this.err_mail = new System.Windows.Forms.Label();
            this.tbx_nom_service = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_resp_service = new System.Windows.Forms.ComboBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // err_mail
            // 
            this.err_mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.err_mail.AutoSize = true;
            this.err_mail.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_mail.ForeColor = System.Drawing.Color.Red;
            this.err_mail.Location = new System.Drawing.Point(40, 97);
            this.err_mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.err_mail.Name = "err_mail";
            this.err_mail.Size = new System.Drawing.Size(93, 20);
            this.err_mail.TabIndex = 59;
            this.err_mail.Text = "Champ vide";
            this.err_mail.Visible = false;
            // 
            // tbx_nom_service
            // 
            this.tbx_nom_service.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_nom_service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_nom_service.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nom_service.Location = new System.Drawing.Point(43, 75);
            this.tbx_nom_service.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_nom_service.Name = "tbx_nom_service";
            this.tbx_nom_service.Size = new System.Drawing.Size(265, 20);
            this.tbx_nom_service.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nom service";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 22);
            this.label10.TabIndex = 61;
            this.label10.Text = "Responsable service";
            // 
            // cbb_resp_service
            // 
            this.cbb_resp_service.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_resp_service.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_resp_service.FormattingEnabled = true;
            this.cbb_resp_service.Location = new System.Drawing.Point(43, 152);
            this.cbb_resp_service.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_resp_service.Name = "cbb_resp_service";
            this.cbb_resp_service.Size = new System.Drawing.Size(266, 30);
            this.cbb_resp_service.TabIndex = 60;
            // 
            // btn_create
            // 
            this.btn_create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(196)))), ((int)(((byte)(179)))));
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(44, 225);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(104, 32);
            this.btn_create.TabIndex = 62;
            this.btn_create.Text = "CRÉER";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewCreateServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 520);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbb_resp_service);
            this.Controls.Add(this.err_mail);
            this.Controls.Add(this.tbx_nom_service);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCreateServices";
            this.Text = "ViewCreateServices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label err_mail;
        private System.Windows.Forms.TextBox tbx_nom_service;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_resp_service;
        private System.Windows.Forms.Button btn_create;
    }
}