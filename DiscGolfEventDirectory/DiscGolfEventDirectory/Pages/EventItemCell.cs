﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;


namespace DiscGolfEventDirectory
{
    class EventItemCell : ViewCell
    {
        public EventItemCell()
        {
            var label = new Label
            {
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.StartAndExpand
            };

            label.SetBinding(Label.TextProperty, "Name");
            var tick = new Image
            {
                Source = FileImageSource.FromFile("check.png"),
                HorizontalOptions = LayoutOptions.End
            };

            tick.SetBinding(Image.IsVisibleProperty, "Done");

            var layout = new StackLayout
            {
                Padding = new Thickness(20, 0, 20, 0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = { label, tick }
            };

            View = layout;
        }
    }
}
