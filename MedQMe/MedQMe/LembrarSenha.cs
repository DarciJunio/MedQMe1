using System;
using Xamarin.Forms;

namespace MedQMe
{
	public class LembrarSenha : ContentPage
	{
		private Button btnEnviar = new Button {							
			Text = "Enviar",
			TextColor = Xamarin.Forms.Color.White,
			BackgroundColor = Xamarin.Forms.Color.FromRgb (160, 210, 170),
		};

		private Entry txtEmail = new Entry {
			TextColor = Xamarin.Forms.Color.Black,
			BackgroundColor = Xamarin.Forms.Color.FromRgb(241,241,241),
			Keyboard = Xamarin.Forms.Keyboard.Email,
			FontSize = 14
		};

		private ILoginManager _ilm;

		public LembrarSenha (ILoginManager ilm)
		{			
			_ilm = ilm;

			InitializeComponent ();

			NavigationPage.SetHasNavigationBar (this, false);

			btnEnviar.Clicked += OnButtonClicked;
		}

		private void InitializeComponent ()
		{
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,				
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Xamarin.Forms.Color.White,
				Padding = new Thickness (50, 50, 50, 5),
				Spacing = 30,
				Children = {
					new Image { 
						WidthRequest = 130,
						HeightRequest = 80,
						Source = "iconMedQMe.png",
						BackgroundColor = Xamarin.Forms.Color.White								
					},
					new Label {
						Text = "E-mail cadastrado",
						FontSize = 14,
						TextColor = Xamarin.Forms.Color.Gray
					},
					txtEmail,
					btnEnviar
				},

			};
		}

		void OnButtonClicked(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty (txtEmail.Text)) {
				DisplayAlert ("Erro", "O email deve ser preenchido.", "Retornar");
			} else {				
				Navigation.PushAsync (new Login (_ilm));
			}
		}

	}
}

