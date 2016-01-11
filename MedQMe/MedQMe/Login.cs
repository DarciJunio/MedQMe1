using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedQMe
{
	public class Login : ContentPage
	{
		private Button btnEntrar = new Button {							
			Text = "Entrar",
			TextColor = Xamarin.Forms.Color.White,
			BackgroundColor = Xamarin.Forms.Color.FromRgb (160, 210, 170),
		};

		private Button btnLembrarSenha = new Button {
			Text = "Não sei minha senha",
			TextColor = Xamarin.Forms.Color.FromRgb (160, 210, 170),
			BackgroundColor = Xamarin.Forms.Color.Transparent,
			BorderColor = Xamarin.Forms.Color.Transparent,
			FontSize = 13
		};

		private Button btnCadastrar = new Button {
			Text = "Você é novo? Cadastre-se",
			TextColor = Xamarin.Forms.Color.FromRgb (160, 210, 170),
			BackgroundColor = Xamarin.Forms.Color.Transparent,
			BorderColor = Xamarin.Forms.Color.Transparent,
			FontSize = 13
		};
		private Entry txtEmail = new Entry {
			Placeholder = "E-mail cadastrado no MedQMe", 
			FontSize = 14,
			TextColor = Xamarin.Forms.Color.Gray,
			Keyboard = Xamarin.Forms.Keyboard.Email
		};
				
		private Entry txtSenha = new Entry {
			Placeholder = "Senha",
			FontSize = 14,
			TextColor = Xamarin.Forms.Color.Gray,
			IsPassword = true
		};

		private ILoginManager _ilm;

		public Login (ILoginManager ilm)
		{			
			_ilm = ilm;

			InitializeComponent ();

			NavigationPage.SetHasNavigationBar (this, false);

			Clicked_btnEntrar ();

			Clicked_btnLembrarSenha ();

			Clicked_btnCadastrar ();

		}

		private void Clicked_btnEntrar ()
		{
			btnEntrar.Clicked += (object sender, EventArgs e) => {
				if (String.IsNullOrEmpty (txtEmail.Text) || String.IsNullOrEmpty (txtSenha.Text)) {
					DisplayAlert ("Erro", "O email e a senha devem ser preenchido.", "Retornar");
				} 
			};
		}

		private void Clicked_btnLembrarSenha ()
		{
			btnLembrarSenha.Clicked += (object sender, EventArgs e) => {
				_ilm.ShowMainPage (new LembrarSenha (_ilm));
			};
		}

		private void Clicked_btnCadastrar ()
		{
			btnCadastrar.Clicked += (object sender, EventArgs e) => {
				_ilm.ShowMainPage (new Cadastro (_ilm));
			};
		}

		private void InitializeComponent ()
		{
			
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,				
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Xamarin.Forms.Color.White,
				Padding = new Thickness (50, 50, 50, 5),
				Spacing = 25,
				Children = {
					new Image { 
						WidthRequest = 130,
						HeightRequest = 80,
						Source = "iconMedQMe.png",
						BackgroundColor = Xamarin.Forms.Color.White								
					},
					txtEmail,
					txtSenha,
					btnEntrar,
					btnLembrarSenha,
					btnCadastrar
				}
			};
		}

	}
}

