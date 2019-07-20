using Plugin.Media.Abstractions;
using System.Threading.Tasks;

namespace ItemsClassifier.Interfaces
{
    public interface IImageClassifier
    {
        Task<string> AnalyzeImage(MediaFile image);
    }
}
