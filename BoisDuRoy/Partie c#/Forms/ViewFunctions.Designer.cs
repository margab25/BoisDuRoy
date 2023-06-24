namespace BoisDuRoy_Margaux_Louison.Forms
{
    partial class ViewFunctions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFunctions));
            this.dgvFunctions = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnn_del = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btn_printer = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunctions
            // 
            this.dgvFunctions.AllowUserToAddRows = false;
            this.dgvFunctions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFunctions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFunctions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFunctions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFunctions.BackgroundColor = System.Drawing.Color.White;
            this.dgvFunctions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFunctions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFunctions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(196)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunctions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFunctions.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat Light", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(196)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunctions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFunctions.DoubleBuffered = true;
            this.dgvFunctions.EnableHeadersVisualStyles = false;
            this.dgvFunctions.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFunctions.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(196)))), ((int)(((byte)(179)))));
            this.dgvFunctions.HeaderForeColor = System.Drawing.Color.White;
            this.dgvFunctions.Location = new System.Drawing.Point(9, 76);
            this.dgvFunctions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFunctions.MultiSelect = false;
            this.dgvFunctions.Name = "dgvFunctions";
            this.dgvFunctions.ReadOnly = true;
            this.dgvFunctions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunctions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFunctions.RowHeadersVisible = false;
            this.dgvFunctions.RowHeadersWidth = 51;
            this.dgvFunctions.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFunctions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvFunctions.RowTemplate.DividerHeight = 1;
            this.dgvFunctions.RowTemplate.Height = 40;
            this.dgvFunctions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunctions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunctions.ShowCellErrors = false;
            this.dgvFunctions.Size = new System.Drawing.Size(920, 410);
            this.dgvFunctions.TabIndex = 10;
            this.dgvFunctions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunctions_CellDoubleClick);
            // 
            // btnn_del
            // 
            this.btnn_del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnn_del.FlatAppearance.BorderSize = 0;
            this.btnn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnn_del.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnn_del.ForeColor = System.Drawing.Color.White;
            this.btnn_del.Location = new System.Drawing.Point(818, 23);
            this.btnn_del.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnn_del.Name = "btnn_del";
            this.btnn_del.Size = new System.Drawing.Size(93, 32);
            this.btnn_del.TabIndex = 9;
            this.btnn_del.Text = "SUPPRIMER";
            this.btnn_del.UseVisualStyleBackColor = false;
            this.btnn_del.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_modify.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_modify.FlatAppearance.BorderSize = 0;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify.ForeColor = System.Drawing.Color.White;
            this.btn_modify.Location = new System.Drawing.Point(720, 22);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(93, 32);
            this.btn_modify.TabIndex = 8;
            this.btn_modify.Text = "MODIFIER";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(196)))), ((int)(((byte)(179)))));
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(622, 22);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(93, 32);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "CRÉER";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.button1_Click_1);
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
            this.btn_download.TabIndex = 11;
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.button4_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Location = new System.Drawing.Point(9, 24);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(535, 31);
            this.searchBox.TabIndex = 15;
            this.searchBox.Text = "Rechercher une fonction . . . ";
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
            this.btn_printer.Location = new System.Drawing.Point(586, 22);
            this.btn_printer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_printer.Name = "btn_printer";
            this.btn_printer.Size = new System.Drawing.Size(32, 32);
            this.btn_printer.TabIndex = 19;
            this.btn_printer.UseVisualStyleBackColor = false;
            this.btn_printer.Click += new System.EventHandler(this.button5_Click);
            // 
            // ViewFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 520);
            this.Controls.Add(this.btn_printer);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.dgvFunctions);
            this.Controls.Add(this.btnn_del);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewFunctions";
            this.Text = "FONCTION";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvFunctions;
        private System.Windows.Forms.Button btnn_del;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btn_printer;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}