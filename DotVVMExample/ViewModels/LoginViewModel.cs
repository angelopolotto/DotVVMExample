using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace DotVVMExample.ViewModels
{
    public class LoginViewModel : SiteViewModel
    {
        [Required(ErrorMessage = "Email obrigatório!")]
        [EmailAddress(ErrorMessage = "Email não válido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha obrigatória!")]
        public string Password { get; set; }

        // The user cannot change this field in the browser so there is no point in transferring it from the client to the server
        [Bind(Direction.ServerToClient)]
        public string ErrorMessage { get; set; }

        public void SignIn()
        {
                Context.RedirectToRoute("SiteHomePage");
        }
    }
}

