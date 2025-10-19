using CommunityToolkit.Mvvm.Input;
using Exemplo.MAUI.APP.Navigation;

namespace Exemplo.MAUI.APP.ViewModels.Pages.OnBoarding
{
    public partial class OnBoardingViewModel
    {
        [RelayCommand]
        private async Task LoginWithEmailAndPassword()
        {
            await Shell.Current.GoToAsync(RoutePages.LOGIN_PAGE);
        }
        [RelayCommand]
        private void LoginWithGoogle()
        {

        }

        [RelayCommand]
        private async Task RegisterUserAccount()
        {
            await Shell.Current.GoToAsync(RoutePages.USER_REGISTER_ACCOUNT_PAGE);
        }

    }
}
