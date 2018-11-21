using System.Collections.Generic;
using BethanysPies.Models;

namespace BethanysPies.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}