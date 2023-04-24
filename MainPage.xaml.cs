using CurrencyConverter.ViewModels;

namespace CurrencyConverter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		BindingContext = new MainPageVM();
		InitializeComponent();
	}
}


