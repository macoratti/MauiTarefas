using MauiTarefas.Pages;

namespace MauiTarefas;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetalhesPage), typeof(DetalhesPage));
        Routing.RegisterRoute(nameof(ContatosPage), typeof(ContatosPage));
    }
}
