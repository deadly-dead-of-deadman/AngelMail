using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GUI.Views;

public partial class MailListView : UserControl
{
    public MailListView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}