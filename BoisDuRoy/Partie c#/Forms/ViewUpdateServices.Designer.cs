namespace BoisDuRoy_Margaux_Louison.Forms
{
    partial class ViewUpdateServices
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
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_resp_service = new System.Windows.Forms.ComboBox();
            this.err_nom_service = new System.Windows.Forms.Label();
            this.tbx_nom_service = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.label10.TabIndex = 67;
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
            this.cbb_resp_service.TabIndex = 66;
            // 
            // err_nom_service
            // 
            this.err_nom_service.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.err_nom_service.AutoSize = true;
            this.err_nom_service.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_nom_service.ForeColor = System.Drawing.Color.Red;
            this.err_nom_service.Location = new System.Drawing.Point(40, 97);
            this.err_nom_service.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.err_nom_service.Name = "err_nom_service";
            this.err_nom_service.Size = new System.Drawing.Size(93, 20);
            this.err_nom_service.TabIndex = 65;
            this.err_nom_service.Text = "Champ vide";
            this.err_nom_service.Visible = false;
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
            this.tbx_nom_service.TabIndex = 64;
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
            this.label2.TabIndex = 63;
            this.label2.Text = "Nom service";
            // 
            // btn_modify
            // 
            this.btn_modify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_modify.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_modify.FlatAppearance.BorderSize = 0;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify.ForeColor = System.Drawing.Color.White;
            this.btn_modify.Location = new System.Drawing.Point(44, 225);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(104, 32);
            this.btn_modify.TabIndex = 69;
            this.btn_modify.Text = "MODIFIER";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewUpdateServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 520);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbb_resp_service);
            this.Controls.Add(this.err_nom_service);
            this.Controls.Add(this.tbx_nom_service);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewUpdateServices";
            this.Text = "ViewUpdateServices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_resp_service;
        private System.Windows.Forms.Label err_nom_service;
        private System.Windows.Forms.TextBox tbx_nom_service;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_modify;
    }
}