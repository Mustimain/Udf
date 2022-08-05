using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Udf.Extensions
{
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtensions : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source != null)
            {
                return null;
            }
            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtensions).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}