using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace DotVVMExample.ViewModels
{
    public class SiteViewModel : DotvvmViewModelBase
    {
        /// <summary>
        /// Gets or sets the active page. This is used in the top menu bar to highlight the current menu item.
        /// </summary>
        public virtual string ActivePage => Context.Route.RouteName;
        
        public void SignOut()
        {
            Context.RedirectToRoute("Login");
        }
    }
}

