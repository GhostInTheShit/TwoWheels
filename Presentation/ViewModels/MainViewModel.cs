using CommunityToolkit.Mvvm.ComponentModel;

namespace TwoWheels.Presentation.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private ViewModelBase? _currentViewModel = new BicyclesViewModel();

    public string Some { get; set; }
}