using AppGestionEmpleadosII.UI.Pages.Detalle;

namespace AppGestionEmpleadosII
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute("DetalleEmpleadoPage", typeof(DetalleEmpleadoPage));
            Routing.RegisterRoute("DetalleDepartamentoPage", typeof(DetalleDepartamentoPage));
            Routing.RegisterRoute("DetalleSedePage", typeof(DetalleSedePage));
            InitializeComponent();
        }
    }
}
