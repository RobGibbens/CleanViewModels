using PropertyChanged;
using System.Windows.Input;
using Xamarin.Forms;

namespace CleanViewModels
{
	[ImplementPropertyChanged]
	public class UserViewModel : IViewModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public ICommand LoadUser {
			get {
				return new Command (async () => {
					this.FirstName = "John";
					this.LastName = "Doe";
				});
			}
		}
	}
}