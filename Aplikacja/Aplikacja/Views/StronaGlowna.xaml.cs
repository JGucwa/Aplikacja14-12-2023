﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StronaGlowna : TabbedPage
    {
        public StronaGlowna()
        {
            InitializeComponent();
        }
    }
}