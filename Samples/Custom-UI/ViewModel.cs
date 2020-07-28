using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custon_Label
{
    public class ViewModel
    {
        private double selectedValue;

        public double SelectedValue
        {
            get
            {
                return selectedValue;
            }
            set
            {
                selectedValue = value;
            }
        }
    }
}
