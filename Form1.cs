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
       public static SQLiteConnection conn = null;      
        private Point mousePoint;
        int first = 0;
        public static int login_check = 0;
        Form_login login;
        public Form1()
        {
            InitializeComponent();           
            page21.Visible = true;
            page_auditorium1.Visible = false;                        
            page21.ButtonClicked += button_Click;            
            page_auditorium1.ButtonClicked += button_Click;
            login = new Form_login();
            conn = new SQLiteConnection("Data source=" + path2 + ";Version=3");
           
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
             //   page11.Visible = false;
             //   page21.Visible = true;
                    break;
                case "예약확인":
                 //   page21.Visible = false;
                //    page11.Visible = true;
                    break;
                case "영화예매":
                 //   page21.Visible = false;
              /*      page_auditorium1.Visible = true;
                    if(first == 0)
                        page_auditorium1.load_data();*/

                    break;
                case "구매":
                    //page_auditorium1.Visible = false;                    
                    login.ShowDialog();
                    break;               
            }           

        }
       
    }
}