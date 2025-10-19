using Exemplo.MAUI.APP.ViewModels.Pages.OnBoarding;

namespace Exemplo.MAUI.APP.Views.Pages.OnBoarding;

public partial class OnBoardingPage : ContentPage
{
	public OnBoardingPage()
	{
		InitializeComponent();

		BindingContext = new OnBoardingViewModel();
	}  
}