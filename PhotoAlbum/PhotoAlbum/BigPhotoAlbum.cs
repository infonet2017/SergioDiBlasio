using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum
{
    class BigPhotoAlbum
    {
        private int NumberOfPages;

        public int GetNumberOfPages()
        {
            return this.NumberOfPages;
        }

        //constructor por defecto
        public BigPhotoAlbum()
        {
            this.NumberOfPages = 64;
        }
    }
}
