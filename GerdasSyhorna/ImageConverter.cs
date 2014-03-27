using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace GerdasSyhorna
{
    class ImageConverter
    {

        public static byte[] ToByteArray(Image image)
        {
            byte[] byteArray;


            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byteArray = ms.ToArray();

            }


            return byteArray;
        }

        public static Image ImageFromByteArray(byte[] byteArray)
        {
            Image image;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }







    }

    
    


}
