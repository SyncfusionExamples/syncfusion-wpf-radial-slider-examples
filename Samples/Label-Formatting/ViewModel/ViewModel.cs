using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Label_Formatting
{
    class ViewModel :NotificationObject
    {
        private ICommand drawLabelCommand;
        public ICommand DrawLabelCommand
        {
            get
            {
                if (drawLabelCommand == null)
                    drawLabelCommand = new UpdateLabel();
                return drawLabelCommand;
            }
            set
            {
                drawLabelCommand = value;
            }
        }

        public ViewModel()
        {

        }
    }
}
