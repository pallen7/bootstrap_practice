using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootstrap_practice.ViewModels
{
    public class PagingViewModel
    {
        public int total_items { get; set; }
        public int items_per_page { get; set; }
    }
}
