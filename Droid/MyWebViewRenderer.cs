using System;
using Xamarin.Forms.Platform.Android;
using Android.Webkit;
using Xamarin.Forms;
using ArticleRPWebViewTest.Droid;
using ArticleRPWebViewTest;

[assembly:ExportRendererAttribute(typeof(MyWebView), typeof(MyWebViewRenderer))]

namespace ArticleRPWebViewTest.Droid
{
    public class MyWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);

            Control.Settings.JavaScriptEnabled = true;
            Control.Settings.JavaScriptCanOpenWindowsAutomatically = true;
        }
    }
}

