using Prism.Mvvm;
using Xamarin.Forms;

namespace DemoFlowListView
{
	public class PhotoModel : BindableBase
	{
		private string _url;
		private ImageSource _source;

		public string Url
		{
			get { return _url; }
			set { SetProperty(ref _url, value); }
		}

		public ImageSource Source
		{
			get { return _source; }
			set { SetProperty(ref _source, value); }
		}
	}
}
