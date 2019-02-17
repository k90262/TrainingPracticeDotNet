using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace however
{
    class Class1 : IDisposable
    {
        public Class1()
        {
            MessageBox.Show("Default constructor!");
            //Class99 obj = new Class99();
        }

        public Class1(String name)
        {
            MessageBox.Show(name);
        }

        ~Class1()
        {
            MessageBox.Show("Destructor");
            this.Dispose();
        }

        bool disposed = false;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
                MessageBox.Show("Dispose");
            }
        }
    }
}
