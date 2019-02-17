using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace however
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //Class1 c = new Class1("jackson");
            //Class2 obj = new Class2("name");
            //Class2 obj = new Class2();
            //Class1 obj = new Class1();

            //obj.Dispose();
            //using (Class1 obj = new Class1())
            //{
            //}
            Class1 obj = new Class1();

            obj.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
