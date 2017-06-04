using DataAccess.Entities;
using System.Collections.Generic;

namespace BethanysPieShop.WebUI.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}