using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FTMTools.Model;

namespace FTMTools.ViewModel
{
    public class CommandVM
    {       
        ICommand command
        {
            get
            {
                return new DelegateCommand(o => Task.Run(() =>
                {
                    
                }));
            }
        }
    }
}
