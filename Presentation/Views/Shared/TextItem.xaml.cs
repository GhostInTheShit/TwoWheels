using System.Windows.Controls;

namespace TwoWheels.Presentation.Views.Shared;

public partial class TextItem : UserControl
{
    public TextItem()
    {
        InitializeComponent();
        DataContext = this;
    }
    
    public String Title { get; set; }
    
    public int MaxLength { get; set; }
}