using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodStock01;

namespace FoodStock01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage1 : ContentPage
    {
        public FoodPage1(string title)
        {

            //タイトル
            Title = title;

            //アイコン
            Icon = "apple32.png";


            InitializeComponent();
            BindingContext = new FoodTabViewModel();

        }

        void ChackBoxChanged(object sender, bool isChecked)
        {
            //選択された時の処理
            if (isChecked)
            {
                
            }
            //選択が外された時の処理
            else
            {
               
            }
        }

        void OnSearch_Clicked(object sender, EventArgs args)
        {
            /*var Recipe = new WebView
            {
                Source = "http://cookpad.com/search/"
            };
            Content = Recipe;*/

            //Application.Current.MainPage = new RecipePage("レシピ");
        }
    }
}