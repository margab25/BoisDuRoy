namespace BoisDuRoy_Margaux_Louison.Forms
{
    partial class ViewUptdateEmployees
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
            this.err_prenom = new System.Windows.Forms.Label();
            this.err_nom = new System.Windows.Forms.Label();
            this.err_nss = new System.Windows.Forms.Label();
            this.err_tel = new System.Windows.Forms.Label();
            this.err_mail = new System.Windows.Forms.Label();
            this.cbb_fonction = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_service = new System.Windows.Forms.ComboBox();
            this.tbx_prenom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_nom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_dateNaiss = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_dateEmb = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_nss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_tel = new System.Windows.Forms.TextBox();
            this.tbx_mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_modify = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // err_prenom
            // 
            this.err_prenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.err_prenom.AutoSize = true;
            this.err_prenom.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_prenom.ForeColor = System.Drawing.Color.Red;
            this.err_prenom.Location = new System.Drawing.Point(325, 167);
            this.err_prenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.err_prenom.Name = "err_prenom";
            this.err_prenom.Size = new System.Drawing.Size(93, 20);
            this.err_prenom.TabIndex = 61;
            this.err_prenom.Text = "Champ vide";
            this.err_prenom.Visible = false;
            // 
            // err_nom
            // 
            this.err_nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.err_nom.AutoSize = true;
            this.err_nom.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_nom.ForeColor = System.Drawing.Color.Red;
            this.err_nom.Location = new System.Drawing.Point(325, 98);
            this.err_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.err_nom.Name = "err_nom";
            this.err_nom.Size = new System.Drawing.Size(93, 20);
            this.err_nom.TabIndex = 60;
            this.err_nom.Text = "Champ vide";
            this.err_nom.Visible = false;
            // 
            // err_nss
            // 
            this.err_nss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.err_nss.AutoSize = true;
            this.err_nss.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_nss.ForeColor = System.Drawing.Color.Red;
            this.err_nss.Location = new System.Drawing.Point(39, 237);
            this.err_nss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.err_nss.Name = "err_nss";
            this.err_nss.Size = new System.Drawing.Size(135, 20);
            this.err_nss.TabIndex = 58;
            this.err_nss.Text = "Numéro Incorrect";
            this.err_nss.Visible = false;
            // 
            // err_tel
            // 
            this.err_tel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.err_tel.AutoSize = true;
            this.err_tel.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_tel.ForeColor = System.Drawing.Color.Red;
            this.err_tel.Location = new System.Drawing.Point(39, 167);
            this.err_tel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.err_tel.Name = "err_tel";
            this.err_tel.Size = new System.Drawing.Size(216, 20);
            this.err_tel.TabIndex = 57;
            this.err_tel.Text = "Téléphone Incorrect 5 chiffres";
            this.err_tel.Visible = false;
            // 
            // err_mail
            // 
            this.err_mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.err_mail.AutoSize = true;
            this.err_mail.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_mail.ForeColor = System.Drawing.Color.Red;
            this.err_mail.Location = new System.Drawing.Point(39, 98);
            this.err_mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.err_mail.Name = "err_mail";
            this.err_mail.Size = new System.Drawing.Size(130, 20);
            this.err_mail.TabIndex = 56;
            this.err_mail.Text = "[nom]@broy.com";
            this.err_mail.Visible = false;
            // 
            // cbb_fonction
            // 
            this.cbb_fonction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_fonction.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_fonction.FormattingEnabled = true;
            this.cbb_fonction.Location = new System.Drawing.Point(633, 145);
            this.cbb_fonction.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_fonction.Name = "cbb_fonction";
            this.cbb_fonction.Size = new System.Drawing.Size(266, 30);
            this.cbb_fonction.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(629, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 22);
            this.label11.TabIndex = 52;
            this.label11.Text = "Fonction";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(629, 51);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 22);
            this.label10.TabIndex = 51;
            this.label10.Text = "Service";
            // 
            // cbb_service
            // 
            this.cbb_service.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_service.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_service.FormattingEnabled = true;
            this.cbb_service.Location = new System.Drawing.Point(633, 76);
            this.cbb_service.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_service.Name = "cbb_service";
            this.cbb_service.Size = new System.Drawing.Size(266, 30);
            this.cbb_service.TabIndex = 50;
            // 
            // tbx_prenom
            // 
            this.tbx_prenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_prenom.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_prenom.Location = new System.Drawing.Point(329, 145);
            this.tbx_prenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_prenom.Name = "tbx_prenom";
            this.tbx_prenom.Size = new System.Drawing.Size(265, 20);
            this.tbx_prenom.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 22);
            this.label9.TabIndex = 48;
            this.label9.Text = "Prénom";
            // 
            // tbx_nom
            // 
            this.tbx_nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_nom.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nom.Location = new System.Drawing.Point(329, 76);
            this.tbx_nom.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_nom.Name = "tbx_nom";
            this.tbx_nom.Size = new System.Drawing.Size(265, 20);
            this.tbx_nom.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(325, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Nom";
            // 
            // dtp_dateNaiss
            // 
            this.dtp_dateNaiss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_dateNaiss.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateNaiss.Location = new System.Drawing.Point(633, 283);
            this.dtp_dateNaiss.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dateNaiss.Name = "dtp_dateNaiss";
            this.dtp_dateNaiss.Size = new System.Drawing.Size(266, 27);
            this.dtp_dateNaiss.TabIndex = 43;
            this.dtp_dateNaiss.Value = new System.DateTime(2023, 3, 28, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(629, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "Date naissance";
            // 
            // dtp_dateEmb
            // 
            this.dtp_dateEmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_dateEmb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateEmb.Location = new System.Drawing.Point(633, 214);
            this.dtp_dateEmb.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_dateEmb.Name = "dtp_dateEmb";
            this.dtp_dateEmb.Size = new System.Drawing.Size(266, 27);
            this.dtp_dateEmb.TabIndex = 41;
            this.dtp_dateEmb.Value = new System.DateTime(2023, 3, 28, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(629, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 22);
            this.label5.TabIndex = 40;
            this.label5.Text = "Date embauche";
            // 
            // tbx_nss
            // 
            this.tbx_nss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_nss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_nss.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nss.Location = new System.Drawing.Point(42, 214);
            this.tbx_nss.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_nss.Name = "tbx_nss";
            this.tbx_nss.Size = new System.Drawing.Size(265, 20);
            this.tbx_nss.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Sécurité sociale";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Téléphone";
            // 
            // tbx_tel
            // 
            this.tbx_tel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_tel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_tel.Location = new System.Drawing.Point(42, 145);
            this.tbx_tel.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_tel.Name = "tbx_tel";
            this.tbx_tel.Size = new System.Drawing.Size(265, 20);
            this.tbx_tel.TabIndex = 36;
            // 
            // tbx_mail
            // 
            this.tbx_mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_mail.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_mail.Location = new System.Drawing.Point(42, 76);
            this.tbx_mail.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_mail.Name = "tbx_mail";
            this.tbx_mail.Size = new System.Drawing.Size(265, 20);
            this.tbx_mail.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mail";
            // 
            // btn_modify
            // 
            this.btn_modify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_modify.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_modify.FlatAppearance.BorderSize = 0;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify.ForeColor = System.Drawing.Color.White;
            this.btn_modify.Location = new System.Drawing.Point(794, 401);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(104, 32);
            this.btn_modify.TabIndex = 62;
            this.btn_modify.Text = "MODIFIER";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(392, 379);
            this.labelTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(0, 13);
            this.labelTest.TabIndex = 63;
            // 
            // ViewUptdateEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 520);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.err_prenom);
            this.Controls.Add(this.err_nom);
            this.Controls.Add(this.err_nss);
            this.Controls.Add(this.err_tel);
            this.Controls.Add(this.err_mail);
            this.Controls.Add(this.cbb_fonction);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbb_service);
            this.Controls.Add(this.tbx_prenom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_nom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_dateNaiss);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_dateEmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_nss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_tel);
            this.Controls.Add(this.tbx_mail);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewUptdateEmployees";
            this.Text = "ViewUptdateEmployees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label err_prenom;
        private System.Windows.Forms.Label err_nom;
        private System.Windows.Forms.Label err_nss;
        private System.Windows.Forms.Label err_tel;
        private System.Windows.Forms.Label err_mail;
        private System.Windows.Forms.ComboBox cbb_fonction;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_service;
        private System.Windows.Forms.TextBox tbx_prenom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_nom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_dateNaiss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_dateEmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_nss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_tel;
        private System.Windows.Forms.TextBox tbx_mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Label labelTest;
    }
}