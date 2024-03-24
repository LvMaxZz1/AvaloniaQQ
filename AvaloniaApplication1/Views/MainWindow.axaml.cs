using System;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Media;
using AvaloniaApplication1.ViewModels;
using AvaloniaApplication1.ViewModels.DataBinding;

namespace AvaloniaApplication1.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var model = new MainWindowViewModel();
        this.DataContext = model;
    }
    
    private void LoginStartButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Popup.IsOpen = !Popup.IsOpen;
    }

    private void InputElement_OnTapped(object? sender, TappedEventArgs e)
    {
        if (e.Source is Ellipse clickedEllipse)
        {
            // 获取点击的 Ellipse 对应的数据上下文
            if (clickedEllipse.DataContext is ComboLoginStartItem item)
            {
                LoginStartButton.Background = item.Content switch
                {
                           "Green" => Brushes.Green,
                           "Red" => Brushes.Red,
                           "Yellow" => Brushes.Yellow,
                           _ => Brushes.Green
                };

            }
        }
        Popup.IsOpen = !Popup.IsOpen;
    }

    private void InputElement_OnTappeded(object? sender, TappedEventArgs e)
    {
        if (e.Source is TextBlock clickedEllipse)
        {
            // 获取点击的 Ellipse 对应的数据上下文
            if (clickedEllipse.DataContext is ComboLoginStartItem item)
            {
                LoginStartButton.Background = item.Tag switch
                {
                    "在线" => Brushes.Green,
                    "离开" => Brushes.Red,
                    "隐身" => Brushes.Yellow,
                    _ => Brushes.Green
                };

            }
        }
        Popup.IsOpen = !Popup.IsOpen;
    }
}