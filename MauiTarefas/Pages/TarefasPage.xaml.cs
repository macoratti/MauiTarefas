using MauiTarefas.ViewModels;

namespace MauiTarefas.Pages;

public partial class TarefasPage : ContentPage
{
	public TarefasPage(TarefasPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}