using AppGestionEmpleadosII.PagesViewModels;

namespace AppGestionEmpleadosII.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageModel mainPageModel)
    {
        BindingContext = mainPageModel;
        InitializeComponent();
    }

}
