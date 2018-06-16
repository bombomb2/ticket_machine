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
namespace ticket
{
    
    public partial class Form1 : Form
    {

       public static string path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName+"\\data.sqlite";       
       public static SQLiteConnection conn = null;      
        private Point mousePoint;
        int first = 0;
        public static bool is_nonmember = false; //이거 추가
        public static int login_check = 0;
        Form_login login;

        public Form1()
        {
            InitializeComponent();
            page21.Visible = false ;
            page_movie_select1.Visible = false;
            page_auditorium1.Visible = false;
            selction1.Visible = false;
            pagemoney1.Visible = false;
            confirm1.Visible = true;
            how_much1.Visible = false;
            recheck1.Visible = false;
            bihoywon_page_11.Visible = false;
            bihoywon_page_21.Visible = false;
            page_checkBook1.Visible = false;
            page_nonmember_login1.Visible = false;  
            pagemoney1.ButtonClicked += button_Click;
            page21.ButtonClicked += button_Click;            
            page_auditorium1.ButtonClicked += button_Click;
            page_movie_select1.ButtonClicked += button_Click;
            selction1.ButtonClicked += button_Click;
            how_much1.ButtonClicked += button_Click;
            confirm1.ButtonClicked += button_Click;
            recheck1.ButtonClicked += button_Click;
            bihoywon_page_11.ButtonClicked += button_Click;
            bihoywon_page_21.ButtonClicked += button_Click;
            page_nonmember_login1.ButtonClicked += button_Click;
            login = new Form_login();
           // login.ShowDialog();
            //Form_signup sign = new Form_signup();
            //sign.ShowDialog();
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
         
            switch(temp)
            {               
                case "예약확인":
                    login.ShowDialog();
                    if (login_check == 1)
                    {
                        page_checkBook1.Visible = true;
                        page_checkBook1.load_name();
                        page_checkBook1.load_data();
                    }
                    else if (login_check == 2) //비회원 예매 확인
                    {
                        page_nonmember_login1.Visible = true;
                    }
                    break;
                case "영화예매":
                    page21.Visible = false;
                    page_movie_select1.Visible = true;
                    page_movie_select1.InitListbox();
                    break;

                case "movieselect_cancel":
                    page_movie_select1.Visible = false;
                    page21.Visible = true;
                    break;

                case "movieselect_next":
                    login.ShowDialog();                   
                    if (login_check == 1)
                    {    
                                     
                        page_movie_select1.Visible = false;                        
                        page_auditorium1.load_data();
                        page_auditorium1.Visible = true;
                    }
                    else if(login_check == 2)
                    {
                        page_movie_select1.Visible = false;
                        bihoywon_page_11.Visible = true;
                    }
                    break;
                case "좌석선택다음":
                    page_auditorium1.Visible = false;
                    how_much1.set_default();
                    how_much1.Visible = true;                    
                    break;               
                case "확인구매":
                    how_much1.Visible = false;
                    selction1.Visible = true;
                    break;
                case "카드":
                    selction1.Visible = false;
                    confirm1.Visible = true;
                    break;
                case "현금":
                    selction1.Visible = false;
                    pagemoney1.Visible = true;
                    break;
                case "purchase":
                    pagemoney1.Visible = false;
                    recheck1.test();
                    recheck1.Visible = true;
                    break;
                case "카드확인":
                    confirm1.Visible = false;
                    recheck1.test();
                    recheck1.Visible = true;
                    break;
                case "recheckok":
                    recheck1.Visible = false;
                    page21.Visible = true;
                   // this.Close();
                    //Application.Restart();
                    break;
                case "확인취소":                    
                    how_much1.Visible = false;
                    page21.Visible = true;
                    break;
                case "seatcancel":
                    page_auditorium1.Visible = false;
                    page21.Visible = true;
                    break;
                case "카드취소":
                    confirm1.Visible = false;
                    page21.Visible = true;
                    break;
                case "next_nonmember": //비회원 예매 안내 다음버튼 //이거 추가
                    bihoywon_page_11.Visible = false;
                    bihoywon_page_21.Visible = true;
                    break;
                case "finish_nonmember": //이거 추가
                    if (is_nonmember)
                    {
                        bihoywon_page_21.Visible = false;
                        page_auditorium1.load_data();
                        page_auditorium1.Visible = true;
                    }
                    break;
                case "check_nonmember":
                    {
                        page_nonmember_login1.Visible = false;
                        page_checkBook1.Visible = true;
                        page_checkBook1.load_name();
                        page_checkBook1.load_data();
                        break;
                    }
            }           

        }
       
       
    }
}