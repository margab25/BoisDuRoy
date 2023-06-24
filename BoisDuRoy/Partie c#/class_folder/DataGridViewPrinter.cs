using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BoisDuRoy_Margaux_Louison.class_folder
{
    internal class DataGridViewPrinter
    {
        private DataGridView dataGridView;
        private PrintDocument printDocument;
        private PageSettings pageSettings;
        private int rowIndex;
        private int pageCount;

        public DataGridViewPrinter(DataGridView dataGridView, PrintDocument printDocument)
        {
            this.dataGridView = dataGridView;
            this.printDocument = printDocument;
            this.pageSettings = printDocument.DefaultPageSettings;
            this.rowIndex = 0;
            this.pageCount = 0;

            this.printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.PageUnit = GraphicsUnit.Display;

            float leftMargin = pageSettings.Margins.Left;
            float topMargin = pageSettings.Margins.Top;
            float rightMargin = pageSettings.Margins.Right;
            float bottomMargin = pageSettings.Margins.Bottom;

            float pageWidth = pageSettings.PaperSize.Width - leftMargin - rightMargin;
            float pageHeight = pageSettings.PaperSize.Height - topMargin - bottomMargin;

            float x = leftMargin;
            float y = topMargin;

            float[] columnWidths = GetColumnWidths(g, pageWidth);

            while (rowIndex < dataGridView.Rows.Count)
            {
                DataGridViewRow row = dataGridView.Rows[rowIndex];

                if (y + row.Height > pageHeight)
                {
                    rowIndex++;
                    e.HasMorePages = true;
                    return;
                }

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    float width = columnWidths[i];
                    RectangleF cellBounds = new RectangleF(x, y, width, row.Height);
                    g.DrawString(row.Cells[i].FormattedValue.ToString(), dataGridView.Font, Brushes.Black, cellBounds);

                    x += width;
                }

                rowIndex++;
                y += row.Height;
                x = leftMargin;
            }

            rowIndex = 0;
            pageCount++;

            if (pageCount < printDocument.PrinterSettings.Copies)
            {
                e.HasMorePages = true;
            }
        }

        private float[] GetColumnWidths(Graphics g, float pageWidth)
        {
            float[] widths = new float[dataGridView.Columns.Count];
            float totalWidth = 0f;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                DataGridViewColumn column = dataGridView.Columns[i];
                float width = (float)column.Width / (float)dataGridView.Width * pageWidth;

                if (column.Visible)
                {
                    widths[i] = width;
                    totalWidth += width;
                }
            }

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (dataGridView.Columns[i].Visible)
                {
                    widths[i] = widths[i] / totalWidth * pageWidth;
                }
            }

            return widths;
        }

        public void Print()
        {
            this.pageCount = 0;
            this.rowIndex = 0;
            printDocument.Print();
        }
    }
}
