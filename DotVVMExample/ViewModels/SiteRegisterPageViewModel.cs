using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace DotVVMExample.ViewModels
{
    public class SiteRegisterPageViewModel : SiteViewModel
    {
        /// <summary>
        /// Gets the list of groups the current user is assigned in.
        /// </summary>
        public List<ItemData> ItemsData { get; set; } = new List<ItemData>();
        public string Description { get; set; }

        public void Insert()
        {
            ItemsData.Add(new ItemData{ Id = ItemsData.Count+1, Description = Description});
        }

        public SiteRegisterPageViewModel()
        {
            ItemsData.Add( new ItemData{ Id = 1, Description = "Maçã" });
            ItemsData.Add( new ItemData{ Id = 2, Description = "Pêra" });
            ItemsData.Add( new ItemData{ Id = 3, Description = "Goiaba" });
            ItemsData.Add( new ItemData{ Id = 4, Description = "Banana" });
            ItemsData.Add( new ItemData{ Id = 5, Description = "Uva" });
            ItemsData.Add( new ItemData{ Id = 6, Description = "Caqui" });
            ItemsData.Add( new ItemData{ Id = 7, Description = "Carambola" });
        }
    }

    public class ItemData
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}

