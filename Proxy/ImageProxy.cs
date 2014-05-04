using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ImageProxy
    {
        private Image mImage;
        private String mImageFileName;

        public ImageProxy(String imageName)
        {
            this.mImageFileName = imageName;
        }

        public Image image
        {
            get
            {
                if (mImage == null)
                {
                    mImage = Image.LoadImage(this.mImageFileName);
                }
                return this.mImage;
            }
        }
    }
}
