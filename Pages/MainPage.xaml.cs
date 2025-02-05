using BlazorApp.Models;
using BlazorApp.PageModels;

namespace BlazorApp.Pages
{
    public partial class MainPage : ContentPage
    {
        private int count;


        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }

        /// <summary>
        /// 自分で試しに追加してみた関数
        /// C:\data\BlazorApp\Pages\MainPage.xamlのButtonに紐づくメソッドっぽい
        /// 
        ///  InitializeComponent();でビュー情報が読み込まれ、
        ///  x:Name="CounterBtn"の名前と一致し、
        ///  Clicked="OnCounterClicked"でイベントが紐づく。
        ///   
        /// そしてこの関数の処理のカウントが動きボタンにTextが挿入され表示される
        ///  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCounterClicked(object sender, EventArgs e)
        {
            count += 10;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

    }
}