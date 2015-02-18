using System;
using Xamarin.Forms;

namespace CleanViewModels
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new UserPage ();
		}
	}
}