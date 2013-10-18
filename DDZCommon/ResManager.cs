using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Drawing;

namespace DDZCommon
{
    public static class ResManager
    {
        public static Image GetImageRes(string ImageNo)
        {
            return (Image)Properties.RecDDZ.ResourceManager.GetObject(ImageNo);
        }
    }
}
