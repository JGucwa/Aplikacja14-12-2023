﻿using System;
using Xamarin.Forms;
using Aplikacja.Views;
using Xamarin.Forms.Xaml;

namespace Aplikacja
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StronaGlowna());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}