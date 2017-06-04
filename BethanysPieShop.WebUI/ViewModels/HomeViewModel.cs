using System.Collections.Generic;
using DataAccess.Entities;

namespace BethanysPieShop.WebUI.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}