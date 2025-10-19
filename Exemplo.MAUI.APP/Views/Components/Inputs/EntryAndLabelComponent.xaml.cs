namespace Exemplo.MAUI.APP.Views.Components.Inputs;

public partial class EntryAndLabelComponent : ContentView
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title),
                                                                                    typeof(string),
                                                                                    typeof(EntryAndLabelComponent),
                                                                                    string.Empty);

    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder),
                                                                                  typeof(string),
                                                                                  typeof(EntryAndLabelComponent),
                                                                                  string.Empty);

    public static readonly BindableProperty KeyboardProperty = BindableProperty.Create(nameof(Keyboard),
                                                                                typeof(Keyboard),
                                                                                typeof(EntryAndLabelComponent),
                                                                                Keyboard.Default);

    public string Title { get => (string)GetValue(TitleProperty); }
    public string Placeholder { get => (string)GetValue(PlaceholderProperty); }
    public Keyboard Keyboard { get => (Keyboard)GetValue(KeyboardProperty); }

    public EntryAndLabelComponent()
    {
        InitializeComponent();
    }
}