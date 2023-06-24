namespace BoisDuRoy_Margaux_Louison.Forms
{
    partial class ViewConnexionApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewConnexionApp));
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.err_nomFonction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_matricule
            // 
            this.txt_matricule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_matricule.Font = new System.Drawing.Font("Montserrat Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricule.ForeColor = System.Drawing.Color.Gray;
            this.txt_matricule.Location = new System.Drawing.Point(328, 236);
            this.txt_matricule.Margin = new System.Windows.Forms.Padding(2);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(281, 30);
            this.txt_matricule.TabIndex = 0;
            this.txt_matricule.Text = "Matricule";
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Montserrat Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Gray;
            this.txt_password.Location = new System.Drawing.Point(328, 290);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(281, 30);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "Mot de passe";
            // 
            // button_connect
            // 
            this.button_connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(196)))), ((int)(((byte)(179)))));
            this.button_connect.FlatAppearance.BorderSize = 0;
            this.button_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connect.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connect.ForeColor = System.Drawing.Color.White;
            this.button_connect.Location = new System.Drawing.Point(400, 375);
            this.button_connect.Margin = new System.Windows.Forms.Padding(2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(139, 38);
            this.button_connect.TabIndex = 13;
            this.button_connect.Text = "Se connecter";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 146);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bois du Roy";
            // 
            // err_nomFonction
            // 
            this.err_nomFonction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.err_nomFonction.AutoSize = true;
            this.err_nomFonction.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_nomFonction.ForeColor = System.Drawing.Color.Red;
            this.err_nomFonction.Location = new System.Drawing.Point(326, 332);
            this.err_nomFonction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.err_nomFonction.Name = "err_nomFonction";
            this.err_nomFonction.Size = new System.Drawing.Size(136, 20);
            this.err_nomFonction.TabIndex = 31;
            this.err_nomFonction.Text = "Champs incorrect";
            this.err_nomFonction.Visible = false;
            // 
            // ViewConnexionApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 520);
            this.Controls.Add(this.err_nomFonction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_matricule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewConnexionApp";
            this.Text = "HOME";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label err_nomFonction;
    }
}