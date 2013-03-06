﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tho7_Week3.ImageModifications.Filters
{
    public abstract class VisionAlgorithm
    {
        private String _Name;

        public String Name {
            get
            {
                return _Name;
            }
            set
            {
                _Name = Name;
            }
        }
        public VisionAlgorithm(String name)
        {
            this._Name = name;
        }
        
        public abstract Bitmap DoAlgorithm(Bitmap sourceImage);

        
    }

}
