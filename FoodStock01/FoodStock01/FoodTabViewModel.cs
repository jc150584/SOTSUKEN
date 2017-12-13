using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FoodStock01
{
    public class FoodTabViewModel
    {
        public ICommand GoToRecipe { get; set; }

        public FoodTabViewModel()
        {
            GoToRecipe = new Command((PageName) =>
            {
                var Page = PageName as FoodPage1;
                var ParentPage = Page.Parent as TabbedPage;
                ParentPage.CurrentPage = ParentPage.Children[1];
            });
        }
    }
}
