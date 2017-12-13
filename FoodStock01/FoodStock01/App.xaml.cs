using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;


namespace FoodStock01
{
    public partial class App : Application
    {
        public App()
        {

            // TabbedPageをMainPageとしてセットする
            MainPage = new NavigationPage(new MainPage());
            /*{
                Children = {
                   new FoodPage1("食材"),
                   new StockPage("保存"),
                   new EntryPage1("登録"),
                   new MemoPage1("メモ"),
                   new SettingPage("設定"),
                   new RecipePage("レシピ")
                }
            };*/
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
