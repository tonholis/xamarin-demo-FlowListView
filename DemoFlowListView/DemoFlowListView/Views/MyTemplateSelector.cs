using System;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace DemoFlowListView.Views
{

	public class MyTemplateSelector : FlowTemplateSelector
	{
		private DataTemplate _imageTemplate;

		protected override DataTemplate OnSelectTemplate(object item, int columnIndex, BindableObject container)
		{
			var photo = item as PhotoModel;

			if (photo.Source == null)
			{
				photo.Source = photo.Url.StartsWith("http")
					? ImageSource.FromUri(new Uri(photo.Url))
					: ImageSource.FromFile(photo.Url);
			}

			return _imageTemplate ?? (_imageTemplate = new DataTemplate(typeof(PhotoTemplate)));
		}
	}

	public class PhotoTemplate : Image
	{
		public PhotoTemplate()
		{
			HeightRequest = 90;
			SetBinding(SourceProperty, new Binding("Source"));
			Margin = new Thickness(0, 5, 0, 5);
			VerticalOptions = LayoutOptions.Start;
		}
	}

}
