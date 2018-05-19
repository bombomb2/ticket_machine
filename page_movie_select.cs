using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace ticket
{
    public partial class page_movie_select : UserControl
    {
        public string path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\data.sqlite";
        public SQLiteConnection conn = null;

        public page_movie_select()
        {
            conn = new SQLiteConnection("Data source=" + path2 + ";Version=3");
            conn.Open();
            InitializeComponent();
            InitListbox();
        
        }

        private void InitListbox()
        {
       
            string sql = "SELECT DISTINCT title from movie, timetable where movie.title_num = timetable.title_num;";
            SQLiteCommand cmd2 = new SQLiteCommand(sql, conn);
            SQLiteDataReader rdr = cmd2.ExecuteReader();

            while (rdr.Read())
            {
                listBox_movie_select.Items.Add(rdr["title"]);
            }

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e) //목록이 그려질 때 발생하는 DrawItem 이벤트 수정
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? Brushes.Red : new SolidBrush(e.BackColor); //BackColor 수정 하는 곳
            g.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawString(listBox_movie_select.Items[e.Index].ToString(), e.Font,
                ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? Brushes.Black : new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault); //ForeColor 수정하는 곳 
            e.DrawFocusRectangle();
        }
    }
}
