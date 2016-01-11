using Xamarin.Forms;
using MedQMe;

namespace MedQMe
{
	public class App : Application, ILoginManager
	{
		public App ()
		{
			MainPage = new NavigationPage (new Login (this));
		}

		public void ShowMainPage (ContentPage page)
		{
			MainPage = new NavigationPage (page);
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

