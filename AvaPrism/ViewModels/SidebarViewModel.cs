using System;
using System.Collections.Generic;
using AvaPrism.Models;
using AvaPrism.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace AvaPrism.ViewModels
{
	public class SidebarViewModel : ViewModelBase
	{
		private const int Collapsed = 40;
		private const int Expanded = 200;

        private readonly IRegionManager _regionManager;

        public SidebarViewModel(IRegionManager regionManager)
		{
            _regionManager = regionManager;
			Title = "Navigation";
			FlyoutWidth = Expanded;
        }

        private int _flyoutWidth;
        public int FlyoutWidth
        {
            get { return _flyoutWidth; }
            set { SetProperty(ref _flyoutWidth, value); }
        }

        public DelegateCommand CmdFlyoutMenu => new DelegateCommand(() =>
        {
            var isExpanded = FlyoutWidth == Expanded;
            FlyoutWidth= isExpanded ? Collapsed : Expanded;
        });

        public DelegateCommand CmdDashboard =>
             new DelegateCommand(() =>
             {
                 _regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(DashboardView));
             });

        public DelegateCommand CmdSettings =>
             new DelegateCommand(() =>
             {
                 _regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(SettingsView));
             });


    }
}