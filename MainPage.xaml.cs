namespace MauiApp2;

public partial class MainPage : ContentPage
{

    public List<int> Numbers { get; } = Enumerable.Range(1, 100).ToList();
    public MainPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

}

