using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourse
{
    
    class MenuItem
    {
        public string name = "";
        public MenuItem(string name)
        {
            this.name = name;
        }
        public virtual void MainF() { }
    }
}
