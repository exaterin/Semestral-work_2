﻿using System;
using Xamarin.Forms;

namespace Semestral_Work {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }
        private async void Start_button(object sender, EventArgs e) { await Navigation.PushAsync(new Menu()); }
    }
}
