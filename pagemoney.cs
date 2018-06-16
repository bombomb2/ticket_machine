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
    public partial class pagemoney : UserControl
    {
        public pagemoney()
        {
            InitializeComponent();
        }
        public delegate void OnButtonClickedEventHandler(object sender, EventArgs e);
        private OnButtonClickedEventHandler buttonClicked;
        public event OnButtonClickedEventHandler ButtonClicked
        {
            add { buttonClicked += value; }
            remove { buttonClicked -= value; }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonClicked.Invoke("purchase", e);
        }
    }
}
