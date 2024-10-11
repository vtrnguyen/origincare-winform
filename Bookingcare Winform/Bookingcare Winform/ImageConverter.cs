using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Bookingcare_Winform
{
    internal class ImageConverter
    {
        public byte[] changeImageToByteArray(Image clinicPicture)
        {
            MemoryStream memoryStream = new MemoryStream();
            clinicPicture.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

            return memoryStream.ToArray();
        }

        public Image convertByteArrayToImage(byte[] image)
        {
            if (image == null || image.Length == 0)
            {
                return null;
            }

            using (MemoryStream memoryStream = new MemoryStream(image))
            {
                return Image.FromStream(memoryStream);
            }
        }

        public Image resizeImage(Image img, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / img.Width;
            var ratioY = (double)maxHeight / img.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(img.Width * ratio);
            var newHeight = (int)(img.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.DrawImage(img, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        public Image makeImageTransparent(Image image, float opacity)
        {
            ColorMatrix colorMatrix = new ColorMatrix
            {
                Matrix33 = opacity
            };

            ImageAttributes imgAttributes = new ImageAttributes();
            imgAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Bitmap transparentImage = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(transparentImage))
            {
                g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imgAttributes);
            }

            return transparentImage;
        }
    }
}
