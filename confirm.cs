using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class confirm : UserControl
    {
       

        public confirm()
        {
            InitializeComponent();
            string[] data = { "국민", "신한", "농협" };
            for (int i = 0; i < data.Length; i++)
                comboBox1.Items.Add(data[i]);
            /*string[] charge = { "일시불", "2개월", "6개월" };
            for (int i = 0; i < charge.Length; i++)
                comboBox2.Items.Add(charge[i]);
             */
            textBox1.MaxLength = 4;
            textBox2.MaxLength = 4;
            textBox3.MaxLength = 4;
            textBox4.MaxLength = 4;
            textBox5.MaxLength = 2;
            textBox6.MaxLength = 2;
            textBox7.MaxLength = 2;
            
            

        }
       public delegate void OnButtonClickedEventHandler(object sender, EventArgs e);
        private OnButtonClickedEventHandler buttonClicked;
        public event OnButtonClickedEventHandler ButtonClicked
        {
            add { buttonClicked += value; }
            remove { buttonClicked -= value; }
        }
       private void Button_clicked(object sender, EventArgs e)        
       {
           Button btn;
           btn = sender as Button;          
           if(btn.Text.Equals("취소"))
           {
               reset();
               buttonClicked.Invoke("카드취소",e);               
           }
           else if(btn.Text.Equals("확인"))
           {             
              
               if (!comboBox1.Text.Equals("") )
               {
                   if (!textBox1.Text.Equals("") || !textBox2.Text.Equals("") || !textBox3.Text.Equals("") || !textBox4.Text.Equals(""))
                   {
                       if (!textBox5.Text.Equals("") || !textBox6.Text.Equals(""))
                       {
                           if (!textBox7.Text.Equals(""))
                           {
                               reset();
                               buttonClicked.Invoke("카드확인", e);
                           }
                           else { MessageBox.Show("비밀번호를 입력해주세요"); }
                       }
                       else { MessageBox.Show("카드 년 월을 입력해주세요"); }
                   }
                   else { MessageBox.Show("카드번호를 입력해주세요"); }
               }
               else 
               {                 
                       MessageBox.Show("카드사를 선택해주세요");
               }
           }
           
        }
       private void reset()
       {
           comboBox1.Text = "";
           textBox1.Text = "";
           textBox2.Text = "";
           textBox3.Text = "";
           textBox4.Text = "";
           textBox5.Text = "";
           textBox6.Text = "";
           textBox7.Text = "";
       }
       
    }
}
