using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TwoWheels.Presentation.ViewModels;

public class BicyclesViewModel  : ViewModelBase
{
    public ObservableCollection<BicycleCardViewModel>  BicycleCards { get; set; }

    public BicyclesViewModel()
    {
        
    }
}