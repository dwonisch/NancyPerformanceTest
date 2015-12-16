using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyPerformanceTest
{
    public class ViewModel
    {
        public List<SubModel> SubModels { get; set; } 
    }

    public class SubModel {
        public List<Item> Items { get; set; } 
    }
    public class Item {
        public string Name { get; set; }
    }
}
