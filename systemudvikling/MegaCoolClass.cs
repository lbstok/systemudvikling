using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemudvikling {
    internal class MegaCoolClass {
        private string _name;

        public string Name { 
            get { return _name; }
            set { _name = value; }
        }

        public MegaCoolClass(string name) {
            _name = name;
        }
    }
}
