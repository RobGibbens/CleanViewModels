using System;
using Xamarin.Forms;

namespace CleanViewModels
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new UserPage ();
		}
	}
}