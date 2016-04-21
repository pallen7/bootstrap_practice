using bootstrap_practice.Model;
using System.Collections.Generic;

namespace bootstrap_practice.ViewModels
{
    public class PagingViewModel
    {
        public int current_page { get; set; }
        public int total_pages { get; set; }
        public IEnumerable<PagingItem> current_items { get; set; }
    }
}
