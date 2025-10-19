using CommunityToolkit.Mvvm.Input;

namespace Exemplo.MAUI.APP.ViewModels.Pages.OnBoarding
{
    public partial class OnBoardingViewModel
    {
        [RelayCommand]
        private async Task LoginWithEmailAndPassword()
        {
            await Shell.Current.GoToAsync("DoLoginPage");
        }
        [RelayCommand]
        private void LoginWithGoogle()
        {

        }

    }
}
