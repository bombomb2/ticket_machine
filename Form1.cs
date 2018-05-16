using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
namespace test
{
    
    public partial class Form1 : Form
    {

        public static string path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName+"\\data.sqlite";
        //public static string path2 = "C:\\Users";
        SQLiteConnection conn = null;      
        private Point mousePoint;       
       
        public Form1()
        {
            InitializeComponent();
            page11.Visible = true;
            page21.Visible = false;
            page_auditorium1.Visible = false;
            page11.ButtonClicked += button_Click;
            page21.ButtonClicked += button_Click;
            page_auditorium1.ButtonClicked += button_Click;          
           
            
        }
        private void send()
        {
          //  page_auditorium1.is;
            page_auditorium.isok = page_auditorium1.Visible;

        }
        private void visiblechange(object sender, EventArgs e)
        {
                  
        }
      

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
       {
            if((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string temp = sender.ToString();
            //MessageBox.Show(temp);      
            switch(temp)
            {
                case "회원가입":              
                page11.Visible = false;
                page21.Visible = true;
                    break;
                case "예약확인":
                    page21.Visible = false;
                    page11.Visible = true;
                    break;
                case "영화예매":
                    page21.Visible = false;
                    page_auditorium1.Visible = true;
                    page_auditorium1.load_data();
                    break;
                case "pass":
                    page_auditorium1.Visible = false;
                    page11.Visible = true;                   
                    break;
            }
           

        }
       
    }
}