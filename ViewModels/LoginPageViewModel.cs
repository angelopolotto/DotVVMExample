using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace DotVVMExample.ViewModels
{
    public class LoginPageViewModel : DotvvmViewModelBase
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public async Task SignInCommand()
        {
            try
            {
                Context.RedirectToUrl("www.google.com.br");
                // Context.InterruptRequest();
            }
            catch (System.Exception e)
            {
                //throw;
                Console.WriteLine(e.Message);
            }
        }
    }
}

