using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace GerdasSyhorna
{
    class ImageConverter
    {

        public static byte[] ToByteArray(Image image)
        {
            byte[] byteArray;

            
            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    image.Save(ms, image.RawFormat);
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    //bugg som kräver att bilden förnyas
                    Bitmap bitmap = new Bitmap(image);
                    bitmap.Save(ms, ImageFormat.Bmp);
                }
             
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
