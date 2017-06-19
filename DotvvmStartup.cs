using System.Reflection;
using DotVVM.Framework;
using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;
using DotVVM.Framework.Routing;

namespace DotVVMExample
{
    public class DotvvmStartup : IDotvvmStartup
    {
        // For more information about this class, visit https://dotvvm.com/docs/tutorials/basics-project-structure
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            ConfigureRoutes(config, applicationPath);
            ConfigureControls(config, applicationPath);
            ConfigureResources(config, applicationPath);
        }

        private void ConfigureRoutes(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.Add("Default", "", "Views/LoginPage.dothtml");
            //config.RouteTable.Add("HomePage", "home", "Views/HomePage.dothtml");
            // Uncomment the following line to auto-register all dothtml files in the Views folder
            config.RouteTable.AutoDiscoverRoutes(new DefaultRouteStrategy(config));    
        }

        private void ConfigureControls(DotvvmConfiguration config, string applicationPath)
        {
            // register code-only controls and markup controls
        }

        private void ConfigureResources(DotvvmConfiguration config, string applicationPath)
        {
            // register custom resources and adjust paths to the built-in resources
            config.Resources.Register(ResourceConstants.JQueryResourceName,
            new ScriptResource() 
            {
                Location = new UrlResourceLocation("https://code.jquery.com/jquery-2.1.1.min.js"),
                LocationFallback = new ResourceLocationFallback(
                        "window.jQuery",
                        new EmbeddedResourceLocation(typeof(DotvvmConfiguration).
                        GetTypeInfo().Assembly, "DotVVM.Framework.Resources.Scripts.jquery-2.1.1.min.js"))
            });
            
            config.Resources.Register("bootstrap-css", new StylesheetResource()
            {
                Location = new UrlResourceLocation("https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css")
            });

            config.Resources.Register("bootstrap", new ScriptResource()
            {
                Location = new UrlResourceLocation("https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"),
                Dependencies = new[] { "bootstrap-css", "jquery" }
            });

            config.Resources.Register("signin", new StylesheetResource()
            {
                Location = new FileResourceLocation("Style/signin.css"),
                Dependencies = new[] { "bootstrap-css", "bootstrap" }
            });

            // ""
            // "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css"
            // ""

            // "https://fonts.googleapis.com/icon?family=Material+Icons"
            // "https://code.getmdl.io/1.3.0/material.indigo-pink.min.css"
            // "https://code.getmdl.io/1.3.0/material.min.js"
        }
    }
}
