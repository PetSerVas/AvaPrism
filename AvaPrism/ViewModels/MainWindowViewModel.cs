using Prism.Regions;

namespace AvaPrism.ViewModels;
public class MainWindowViewModel : ViewModelBase
{
	public MainWindowViewModel(IRegionManager regionManager)
	{
		Title = "Test Prism.Avalonia";
	}
}
