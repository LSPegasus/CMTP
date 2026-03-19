namespace VKFoodApp;

public partial class MainPage : ContentPage
{
    public MainPage(ViewModels.FoodListViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm; // Set the context here instead of XAML
    }
}