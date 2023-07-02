using MauiTarefas.ViewModels;

namespace MauiTarefas.Pages;

public partial class DetalhesPage : ContentPage
{
	public DetalhesPage(DetalhesPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}