using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageCompressorCore
{
    public class ImageCompressor
    {
        public void CompressImage(string path, int quality)
        {
            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException("Quality must be between 0 and 100");
            Image img = null;
            ImageCodecInfo codec = null;
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = new EncoderParameter(Encoder.Quality, quality);
            using (var bmpTemp = new Bitmap(path))
            {
                img = new Bitmap(bmpTemp);
                codec = getEncoderInfo(bmpTemp);
            }
            img.Save(path, codec, encoderParams);
        }

        private ImageCodecInfo getEncoderInfo(Image img)
        {
            foreach (ImageCodecInfo codec in ImageCodecInfo.GetImageDecoders())
                if (codec.FormatID == img.RawFormat.Guid)
                    return codec;
            throw new FormatException("Image format is not supported");
        }
    }
}
