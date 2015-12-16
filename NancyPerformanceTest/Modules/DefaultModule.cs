using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace NancyPerformanceTest.Modules
{
    public class DefaultModule : NancyModule
    {
        public DefaultModule() {
            var data = GetData();

            Get["Plain"] = parameter => View["Plain", data];
            Get["Partials"] = parameter => View["Partials", data];
        }

        private ViewModel GetData() {
            var viewModel = new ViewModel();
            viewModel.SubModels = new List<SubModel>();

            for (int i = 0; i < 10; i++) {
                var subModel = new SubModel();
                subModel.Items = new List<Item>();

                for (int a = 0; a < 10; a++) {
                    subModel.Items.Add(new Item { Name = $"{i}_{a}" });
                }

                viewModel.SubModels.Add(subModel);
            }

            return viewModel;
        }
    }
}
