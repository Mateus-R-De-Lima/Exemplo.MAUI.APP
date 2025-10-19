namespace Exemplo.MAUI.APP.Views.Components.Inputs;

public partial class EntryAndLabelPasswordComponent : ContentView
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title),
                                                                                   typeof(string),
                                                                                   typeof(EntryAndLabelPasswordComponent),
                                                                                   string.Empty);

    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder),
                                                                              typeof(string),
                                                                              typeof(EntryAndLabelPasswordComponent),
                                                                              string.Empty);

    public string Title { get => (string)GetValue(TitleProperty); }
    public string Placeholder { get => (string)GetValue(PlaceholderProperty); }
 


    public EntryAndLabelPasswordComponent()
	{
		InitializeComponent();
	}

    private void ShowHidePassword(object sender, TappedEventArgs e)
    {
        if (EntryPassword.IsPassword)
        {
            EntryPassword.IsPassword = false;
            ImageEye.Source = "icon_eye.png";
        }
        else
        {
            EntryPassword.IsPassword = true;
            ImageEye.Source = "icon_eye_hidden.png";
        }

    }
}