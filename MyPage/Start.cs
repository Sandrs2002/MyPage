using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace MyPage
{
	public class Start : ContentPage
    {
        public List<Button> buttons { get; set; }
		List<ContentPage> pages { get; set; }
		Picker pk;
		public Start()
		{
			StackLayout st = new StackLayout();
			buttons = new List<Button>();
			pages = new List<ContentPage>();
			List<String> files = new List<string> { "Better.jpg", "Breakthrough.jpg", "FakeAndTrue.jpg", "Scientist.jpeg" };
			List<String> dirs = new List<string> { "Twice Better", "Twice Breakthrough", "Twice Fake & True","Twice Scientist" };
            List<Color> colors = new List<Color> { Color.Beige, Color.Lavender, Color.PeachPuff, Color.Pink };
            for (int i = 0; i < files.Count; i++)
			{
				Button b = new Button
				{
					Text = dirs[i],
					TabIndex = i
				};
				buttons.Add(b);
				st.Children.Add(b);
                b.Clicked += B_Clicked;
				AlamLeht p = new AlamLeht(dirs[i], files[i])
				{
                    BackgroundColor = colors[i]
                };
				pages.Add(p);
			}
            pk = new Picker
            {
                ItemsSource = dirs,
                Title = "Choose",
                TitleColor = Color.PeachPuff
            };
            pk.SelectedIndexChanged += Pk_SelectedIndexChanged;
			st.Children.Add(pk);
			Content = st;

		}

        private async void Pk_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Navigation.PushAsync(pages[pk.SelectedIndex]);
        }

        private async void B_Clicked(object sender, EventArgs e)
        {
			Button b = sender as Button;
			await Navigation.PushAsync(pages[b.TabIndex]);
        }
        //BackgroundColor = colors[i]
        //BackgroungColor.Color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

    }

}

