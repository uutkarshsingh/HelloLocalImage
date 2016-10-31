using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI;
using Windows.UI.Text;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloLocalImage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            TextBlock txtblk = new TextBlock();
            txtblk.Text = "Hello, Windows 8";
            txtblk.FontFamily = new FontFamily("Times New Roman");
            txtblk.FontSize = 96;
            txtblk.FontStyle = FontStyle.Italic;
            txtblk.HorizontalAlignment = HorizontalAlignment.Center;
            txtblk.VerticalAlignment = VerticalAlignment.Center;
            ContentGrid.Children.Add(txtblk);
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            int a = 12;

        }
    }
}
