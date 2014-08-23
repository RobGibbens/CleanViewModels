namespace CleanViewModels
{	
	public class UserPageBase :  ViewPage<UserViewModel> {}

	public partial class UserPage : UserPageBase
	{	
		public UserPage ()
		{
			InitializeComponent ();
		}
	}
}