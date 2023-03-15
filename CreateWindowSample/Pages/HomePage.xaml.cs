// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinUICommunity.Common.Helpers;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CreateWindowSample.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SampleWindow sampleWindow = new SampleWindow("Close this window and switch to theme");
            ThemeHelper.Initialize(sampleWindow, BackdropType.DesktopAcrylic);
            sampleWindow.Activate();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SampleWindow sampleWindow = new SampleWindow("Click Problem2 again");
            WindowHelper.TrackWindow(sampleWindow);
            ThemeHelper.Initialize(null, BackdropType.DesktopAcrylic);
            sampleWindow.Activate();
        }
    }
}
