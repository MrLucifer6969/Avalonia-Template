using Avalonia_MVVM_Template.ViewModels;
using DynamicData;
using ReactiveUI;
using System.Windows.Input;
namespace Avalonia_MVVM_Template.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainViewModel MainViewContext { get; set; } = new();

    }
}