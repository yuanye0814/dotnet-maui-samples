﻿using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ControlGallery.Views.Code
{
    class FrameDemoPage : ContentPage
    {
        public FrameDemoPage()
        {
            Label header = new Label
            {
                Text = "Frame",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Frame frame = new Frame
            {
                BorderColor = Colors.Silver,
                HasShadow = true,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Content = new Label
                {
                    Text = "I've been framed!"
                }
            };

            // Build the page.
            Title = "Frame Demo";
            Content = new StackLayout
            {
                Children = 
                {
                    header,
                    frame
                }
            };
        }
    }
}
