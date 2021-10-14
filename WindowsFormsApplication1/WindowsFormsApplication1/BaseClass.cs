using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public abstract class BaseClass
    {
        private BaseClass _owner;

        public BaseClass owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
            }
        }

        public abstract string GetClassCaption();
    }
}
