using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Windows.Input;

namespace CustomControl;

public partial class MyButton : Grid
{

    public string MyText
    {
        get => (string)GetValue(MyTextProperty);
        set => SetValue(MyTextProperty, value);
    }

    public static readonly BindableProperty MyTextProperty =
        BindableProperty.Create(nameof(MyText), typeof(string), typeof(MyButton));
   
    public MyButton()
	{
		InitializeComponent();
        
    }


   

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Debug.WriteLine("clicked!");
    }
}