

namespace CustomControl;

public partial class CartView : ContentView
{

    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CartView), string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(CartView.CardTitleProperty);
        set => SetValue(CartView.CardTitleProperty, value);
    }
    public CartView()
	{
		InitializeComponent();
	}
}