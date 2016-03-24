using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ArticleRPWebViewTest
{
    public partial class MyPageWithWebVIew : ContentPage
    {
        public MyPageWithWebVIew()
        {
            InitializeComponent();
        }

        public void OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            if (e.Result == WebNavigationResult.Success)
            {
                var wv = sender as WebView;
                wv.Eval("loadOutbrainJs()");
            }
        }
    }
}

