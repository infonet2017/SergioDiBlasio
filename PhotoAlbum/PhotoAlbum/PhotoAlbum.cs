using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum
{
    class PhotoAlbum
    {
        private int NumberOfPages;
               
        public int GetNumberOfPages()
        {
            return this.NumberOfPages;
        }

        public void SetNumberOfPages(int numpages)
        {
            this.NumberOfPages = numpages;
        }

        //constructor por defecto
        public PhotoAlbum()
        {
            NumberOfPages = 16;
        }


        public PhotoAlbum(int numpages)
        {
            NumberOfPages = numpages;
        }
    }
}
