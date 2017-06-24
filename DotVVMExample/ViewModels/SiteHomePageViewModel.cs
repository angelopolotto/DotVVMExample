using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace DotVVMExample.ViewModels
{
    public class SiteHomePageViewModel : SiteViewModel
    {
        public void Calc()
        {
            Context.RedirectToRoute("SiteCalcPage");
        }
    }
}

