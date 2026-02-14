using AppGestionEmpleadosII.UI.PagesModel;

namespace AppGestionEmpleadosII.UI.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageModel mainPageModel)
    {
        BindingContext = mainPageModel;
        InitializeComponent();
    }

}
