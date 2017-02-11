using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DemoFlowListView.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private ObservableCollection<PhotoModel> _photos = new ObservableCollection<PhotoModel>();
		public ObservableCollection<PhotoModel> Photos
		{
			get { return _photos; }
			set { SetProperty(ref _photos, value); }
		}

		private bool _isBusy;
		public bool IsBusy
		{
			get { return _isBusy; }
			set { SetProperty(ref _isBusy, value); }
		}

		public MainPageViewModel()
		{
			_photos.Add(new PhotoModel() { Url = "https://1.img-dpreview.com/files/p/TS1200x900~sample_galleries/7638856343/1337405476.jpg" });
			_photos.Add(new PhotoModel() { Url = "https://4.img-dpreview.com/files/p/TS1200x900~sample_galleries/7638856343/6722697655.jpg" });
			_photos.Add(new PhotoModel() { Url = "https://1.img-dpreview.com/files/p/TS1200x900~sample_galleries/7638856343/0650241608.jpg" });
			_photos.Add(new PhotoModel() { Url = "https://2.img-dpreview.com/files/p/TS1200x900~sample_galleries/7638856343/5153427147.jpg" });
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		
		}
	}
}
