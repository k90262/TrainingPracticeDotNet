using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace however
{
    class Class2 : Class1
    {
        public Class2() : this("Hello")
        {
            MessageBox.Show("Class2 default constructor.");
        }

        public Class2(String name) : base(name)
        {
            MessageBox.Show("Class2 constructor.");
        }

        ~Class2()
        {
            MessageBox.Show("Class2 Destructor");
        }
    }
}
