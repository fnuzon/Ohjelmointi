﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CarApp_GUI_
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void trucksButton_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(trucksTextBlock.Text); // "0" -> 0
            value++;
            trucksTextBlock.Text = value.ToString(); // 1 -> "1"
        }

        private void carButton_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(carTextBlock.Text); // "0" -> 0
            value++;
            carTextBlock.Text = value.ToString(); // 1 -> "1"
        }
    }
}
