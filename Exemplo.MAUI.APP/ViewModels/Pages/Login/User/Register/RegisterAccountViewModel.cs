using CommunityToolkit.Mvvm.Input;
using Exemplo.MAUI.APP.Navigation;

namespace Exemplo.MAUI.APP.ViewModels.Pages.Login.User.Register
{
    public partial class RegisterAccountViewModel
    {
        
        [RelayCommand]
        public async Task GoToLoginPage()
        {
            // Ao utilizar "../" na navegação, estamos removendo a tela atual da pilha de navegação.
            // Isso significa que, ao pressionar o botão "Voltar", o app retornará para a tela anterior à atual —
            // ou até mesmo para a tela inicial — dependendo de como a navegação foi estruturada anteriormente. tela inicial ou a tela anterior dependendo do caso 
            var rota = $" ../../{RoutePages.LOGIN_PAGE}";

            await Shell.Current.GoToAsync(rota);
        }
    }
}
