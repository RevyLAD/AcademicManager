using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Academic_Manager
{
    public class UtilityClass
    {
        #region 그리드뷰 속성
        public static void AddNewColumnToDataGridView(DataGridView dgv, string headerText,
                string dataPropertyName, bool visibility, int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.Visible = visibility;
            col.ValueType = typeof(string);
            col.ReadOnly = true;
            col.DefaultCellStyle.Alignment = textAlign;
            dgv.Columns.Add(col);
        }
        #endregion
    }

    public class myGroupBox : GroupBox
    {
        private Color _BorderColor = Color.Red;
        [Description("BorderColor")]
        public Color BorderColor
        {
            get { return _BorderColor; }
            set { _BorderColor = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
 
            Size FontSize = TextRenderer.MeasureText(this.Text,
                                                     this.Font);
   
            Rectangle rec = new Rectangle(e.ClipRectangle.Y,
                                          this.Font.Height / 2,
                                          e.ClipRectangle.Width - 1,
                                          e.ClipRectangle.Height - 1 -
                                          this.Font.Height / 2);

            e.Graphics.DrawRectangle(new Pen(BorderColor), rec);

    
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor),
                new Rectangle(6, 0, FontSize.Width, FontSize.Height));

     
            e.Graphics.DrawString(this.Text, this.Font,
                new Pen(this.ForeColor).Brush, 6, 0);
        }
    }
}
