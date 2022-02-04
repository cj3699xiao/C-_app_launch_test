using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestApp_Bug37924976
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Family_Button_Click(object sender, RoutedEventArgs e)
        {
            bool result = await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-family:"));
            
        }

        private async void Setting_Button_Click(object sender, RoutedEventArgs e)
        {
            bool result = await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-settings:"));
        }

        private async void Feedback_Hub_Button_Click(object sender, RoutedEventArgs e)
        {
            bool result = await Windows.System.Launcher.LaunchUriAsync(new Uri("windows-feedback:"));
        }
    }
}
