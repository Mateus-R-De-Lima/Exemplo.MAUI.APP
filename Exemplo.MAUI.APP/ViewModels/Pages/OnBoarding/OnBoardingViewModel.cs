using System.Windows.Input;

namespace Exemplo.MAUI.APP.ViewModels.Pages.OnBoarding
{
    public class OnBoardingViewModel
    {
        public ICommand LoginWithEmailAndPasswordCommand { get; set; }

        public OnBoardingViewModel()
        {
            LoginWithEmailAndPasswordCommand = new Command(LoginWithEmailAndPassword);
        }
        private void LoginWithEmailAndPassword()
        {

        }

    }
}
