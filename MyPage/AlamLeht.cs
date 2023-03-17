using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyPage
{
	public class AlamLeht : ContentPage
	{
		Label lbl;
		Image img;
		Switch sw;
        public List<Button> buttons { get; set; }
        List<ContentPage> pages { get; set; }

		public AlamLeht (string title, string file)
		{
			lbl = new Label
			{
				Text = title,
				FontAttributes = FontAttributes.Italic,
				FontSize = Device.GetNamedSize(NamedSize.Title,typeof(Label)),
				TextColor = Color.DarkViolet,
				HorizontalOptions = LayoutOptions.Center
			};
			sw = new Switch
			{
				HorizontalOptions = LayoutOptions.Center,
				IsToggled = true,
				BackgroundColor = Color.LavenderBlush

			};
            sw.Toggled += Sw_Toggled;
			img = new Image { Source = file };
			Content = new StackLayout { Children = { lbl, sw, img } };
		}

        private void Sw_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value==true)
            {
                img.IsVisible = true;
            }
            else
            {
                img.IsVisible = false;
            }
        }
    }
    
}


