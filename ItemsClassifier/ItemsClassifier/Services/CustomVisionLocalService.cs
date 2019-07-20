using System.Threading.Tasks;

using Plugin.Media.Abstractions;

using ItemsClassifier.Interfaces;

using Xamarin.Forms;
using Xam.Plugins.OnDeviceCustomVision;
using System.Linq;
using System;

namespace ItemsClassifier.Services
{
    public static class CustomVisionLocalService
    {
        public async static Task<string> ClassifyImage(MediaFile picture)
        {
            //var imageClassifier = DependencyService.Get<IImageClassifier>();
            //var result = await imageClassifier.AnalyzeImage(picture);
            //return result;

            var predictions = await CrossImageClassifier.Current.ClassifyImage(picture.GetStreamWithImageRotatedForExternalStorage());
            var topPrediction = predictions.OrderByDescending(t => t.Probability).First();
            return $"{topPrediction.Tag} ({Math.Round(topPrediction.Probability * 100, 2):0.##} %) --local--";
        }
    }
}
