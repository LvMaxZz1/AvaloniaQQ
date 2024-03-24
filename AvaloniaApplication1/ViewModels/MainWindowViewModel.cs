using System.Collections.Generic;
using System.IO;
using Avalonia.Media.Imaging;
using AvaloniaApplication1.Assets;
using AvaloniaApplication1.ViewModels.DataBinding;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApplication1.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private string? _token;

    [ObservableProperty]
    private Bitmap _logo  = new Bitmap(ItemPathHelper.LogoPath);

    [ObservableProperty]
    private string? _comboBoxContent;
    
    [ObservableProperty]
    private string? _comboTag;

    [ObservableProperty] private List<ComboLoginStartItem> _items =
    [
        new()
        {
            Tag = "在线",
            Content = "Green"
        },

        new()
        {
            Tag = "离开",
            Content = "Red"
        },

        new()
        {
            Tag = "隐身",
            Content = "Yellow"
        }
    ];
}