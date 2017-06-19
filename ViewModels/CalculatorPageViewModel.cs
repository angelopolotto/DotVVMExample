using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace DotVVMExample.ViewModels
{
    public class CalculatorPageViewModel : SiteViewModel
    {
        public int Number1 { get; set; }
            
        public int Number2 { get; set; }
            
        public int Result { get; set; }
            
        public void Calculate() 
        {
            Result = Number1 + Number2;
        }
    }
}

