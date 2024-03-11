using EStimWPF.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace EStimWPF
{   
    internal class ImageGenerator
    {
        public static BitmapImage GenerateImage(string source)
        {
            byte[] binaryData = Convert.FromBase64String(source);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = new MemoryStream(binaryData);
            image.EndInit();
            return image;
        }
    }
}
