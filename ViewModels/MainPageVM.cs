using CommunityToolkit.Mvvm.ComponentModel;

namespace CurrencyConverter.ViewModels
{
	public partial class MainPageVM : ObservableObject
	{
        [ObservableProperty]
        private decimal a;

		public MainPageVM()
		{
		}
	}
}

