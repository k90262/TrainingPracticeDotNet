using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public partial class MemberName
    {
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
            set
            {
                var names = value.Split(' ');
                this.FirstName = names[0];
                this.LastName = names[1];
            }
        }
    }
}
