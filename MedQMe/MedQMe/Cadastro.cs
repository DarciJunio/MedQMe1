using System;
using Xamarin.Forms;

namespace MedQMe
{
	public class Cadastro : ContentPage
	{
		private ILoginManager _ilm;

		public Cadastro (ILoginManager ilm)
		{			
			_ilm = ilm;
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar (this, false);
		}

		private void InitializeComponent ()
		{
			Button btnCadastrar = new Button {
				Text = "Cadastrar",
				TextColor = Xamarin.Forms.Color.White,
				BackgroundColor = Xamarin.Forms.Color.FromRgb (160, 210, 170)
			};

			btnCadastrar.Clicked += OnButtonClicked;

			StackLayout formulario = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,				
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Xamarin.Forms.Color.White,
				Padding = new Thickness (50, 50, 50, 20),
				Spacing = 5,
				Children = {
					new Image { WidthRequest = 130, HeightRequest = 80, Source = "iconMedQMe.png", BackgroundColor = Xamarin.Forms.Color.White }, 
					new Label { Text = "Nome completo", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14 },
					new Label { Text = "Como quero que me chame", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14 },
					new Button { Text = "Feminino", TextColor = Xamarin.Forms.Color.White, BackgroundColor = Xamarin.Forms.Color.FromRgb (160, 210, 170) },
					new Button { Text = "Masculino", TextColor = Xamarin.Forms.Color.White, BackgroundColor = Xamarin.Forms.Color.FromRgb (160, 210, 170) },
					new Label { Text = "E-mail", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14, Keyboard = Xamarin.Forms.Keyboard.Email },
					new Label { Text = "Senha", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14, IsPassword = true },
					new Label { Text = "Confirmar senha", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14, IsPassword = true },
					new Label { Text = "Data de Nascimento", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14},
					new Label { Text = "Cep", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14 },
					new Label { Text = "Estado", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14 },
					new Label { Text = "Cidade", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14 },
					new Label { Text = "Bairro", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14 },
					new Label { Text = "Rua", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14 },
					new Label { Text = "Número", FontSize = 14, TextColor = Xamarin.Forms.Color.Gray },
					new Entry { TextColor = Xamarin.Forms.Color.Black, BackgroundColor = Xamarin.Forms.Color.FromRgb (241, 241, 241), FontSize = 14 },
					btnCadastrar
				}
			};

			var layeringGrid = new Grid ();
			var outerScrollView = new ScrollView ();

			layeringGrid.Children.Add (formulario);

			outerScrollView.Content = layeringGrid;

			Content = outerScrollView;

		}

		void OnButtonClicked(object sender, EventArgs e)
		{
			Navigation.PushAsync (new Login (_ilm));
		}
	}
}

