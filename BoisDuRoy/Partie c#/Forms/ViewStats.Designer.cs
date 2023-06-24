namespace BoisDuRoy_Margaux_Louison.Forms
{
    partial class ViewStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbb_stats = new System.Windows.Forms.ComboBox();
            this.chartStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStat)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_stats
            // 
            this.cbb_stats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_stats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_stats.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_stats.FormattingEnabled = true;
            this.cbb_stats.Items.AddRange(new object[] {
            "",
            "Congé accepter par mois",
            "Congé mis en attente par mois",
            "Total des demandes par mois",
            "Congé en fonction de l\'état"});
            this.cbb_stats.Location = new System.Drawing.Point(12, 11);
            this.cbb_stats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_stats.Name = "cbb_stats";
            this.cbb_stats.Size = new System.Drawing.Size(353, 35);
            this.cbb_stats.TabIndex = 21;
            this.cbb_stats.SelectedIndexChanged += new System.EventHandler(this.cbb_service_SelectedIndexChanged);
            // 
            // chartStat
            // 
            chartArea5.Name = "ChartArea1";
            this.chartStat.ChartAreas.Add(chartArea5);
            legend5.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            this.chartStat.Legends.Add(legend5);
            this.chartStat.Location = new System.Drawing.Point(12, 76);
            this.chartStat.Name = "chartStat";
            series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Font = new System.Drawing.Font("Montserrat Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartStat.Series.Add(series5);
            this.chartStat.Size = new System.Drawing.Size(1227, 509);
            this.chartStat.TabIndex = 22;
            this.chartStat.Text = "chart1";
            // 
            // ViewStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 640);
            this.Controls.Add(this.chartStat);
            this.Controls.Add(this.cbb_stats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStats";
            this.Text = "Statistiques";
            ((System.ComponentModel.ISupportInitialize)(this.chartStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_stats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStat;
    }
}