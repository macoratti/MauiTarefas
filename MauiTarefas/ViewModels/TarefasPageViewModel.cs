using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTarefas.Pages;
using System.Collections.ObjectModel;

namespace MauiTarefas.ViewModels;

public partial class TarefasPageViewModel : ObservableObject
{
    public TarefasPageViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;

        Items.Add(Text);
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }
    }

    [RelayCommand]
    async Task Tap(string texto)
    {
        await Shell.Current.GoToAsync($"{nameof(DetalhesPage)}?Text={texto}");
    }
}