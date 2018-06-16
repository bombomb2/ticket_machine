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
           MessageBox.Show(btn.Text);
           if(btn.Text.Equals("취소"))
           {
               MessageBox.Show("취소");
               buttonClicked.Invoke("카드취소",e);               
           }
           else if(btn.Text.Equals("확인"))
           {
               if (comboBox1.Text != null && textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null && textBox5.Text != null && textBox6.Text != null && textBox7.Text != null && radioButton1.Text != null || radioButton2.Text != null)
                        buttonClicked.Invoke("카드확인", e);
           }
           
        }
 
       
    }
}
