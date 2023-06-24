using System.Windows.Forms;

namespace BoisDuRoy_Margaux_Louison.Forms
{
    partial class ViewCongeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCongeForm));
            this.dgvConges = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_rfs = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_printer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConges)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConges
            // 
            this.dgvConges.AllowUserToAddRows = false;
            this.dgvConges.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvConges.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvConges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConges.BackgroundColor = System.Drawing.Color.White;
            this.dgvConges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConges.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConges.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(196)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConges.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat Light", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(196)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConges.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConges.DoubleBuffered = true;
            this.dgvConges.EnableHeadersVisualStyles = false;
            this.dgvConges.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvConges.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(196)))), ((int)(((byte)(179)))));
            this.dgvConges.HeaderForeColor = System.Drawing.Color.White;
            this.dgvConges.Location = new System.Drawing.Point(9, 76);
            this.dgvConges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConges.MultiSelect = false;
            this.dgvConges.Name = "dgvConges";
            this.dgvConges.ReadOnly = true;
            this.dgvConges.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConges.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConges.RowHeadersVisible = false;
            this.dgvConges.RowHeadersWidth = 51;
            this.dgvConges.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvConges.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvConges.RowTemplate.DividerHeight = 1;
            this.dgvConges.RowTemplate.Height = 40;
            this.dgvConges.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConges.ShowCellErrors = false;
            this.dgvConges.Size = new System.Drawing.Size(920, 410);
            this.dgvConges.TabIndex = 11;
            // 
            // btn_download
            // 
            this.btn_download.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_download.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_download.FlatAppearance.BorderSize = 0;
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.ForeColor = System.Drawing.Color.White;
            this.btn_download.Image = ((System.Drawing.Image)(resources.GetObject("btn_download.Image")));
            this.btn_download.Location = new System.Drawing.Point(549, 23);
            this.btn_download.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(32, 32);
            this.btn_download.TabIndex = 15;
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_rfs
            // 
            this.btn_rfs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rfs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_rfs.FlatAppearance.BorderSize = 0;
            this.btn_rfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rfs.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rfs.ForeColor = System.Drawing.Color.White;
            this.btn_rfs.Location = new System.Drawing.Point(730, 23);
            this.btn_rfs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_rfs.Name = "btn_rfs";
            this.btn_rfs.Size = new System.Drawing.Size(104, 32);
            this.btn_rfs.TabIndex = 14;
            this.btn_rfs.Text = "REFUSER";
            this.btn_rfs.UseVisualStyleBackColor = false;
            this.btn_rfs.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(196)))), ((int)(((byte)(179)))));
            this.btn_accept.FlatAppearance.BorderSize = 0;
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accept.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.ForeColor = System.Drawing.Color.White;
            this.btn_accept.Location = new System.Drawing.Point(622, 23);
            this.btn_accept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(104, 32);
            this.btn_accept.TabIndex = 12;
            this.btn_accept.Text = "ACCEPTER";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Location = new System.Drawing.Point(9, 24);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(535, 31);
            this.searchBox.TabIndex = 16;
            this.searchBox.Text = "Rechercher un employé . . . ";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // btn_printer
            // 
            this.btn_printer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_printer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_printer.FlatAppearance.BorderSize = 0;
            this.btn_printer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printer.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printer.ForeColor = System.Drawing.Color.White;
            this.btn_printer.Image = ((System.Drawing.Image)(resources.GetObject("btn_printer.Image")));
            this.btn_printer.Location = new System.Drawing.Point(586, 23);
            this.btn_printer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_printer.Name = "btn_printer";
            this.btn_printer.Size = new System.Drawing.Size(32, 32);
            this.btn_printer.TabIndex = 17;
            this.btn_printer.UseVisualStyleBackColor = false;
            this.btn_printer.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewCongeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 520);
            this.Controls.Add(this.btn_printer);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_rfs);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.dgvConges);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCongeForm";
            this.Text = "CONGÉ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvConges;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_rfs;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.TextBox searchBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btn_printer;
    }
}