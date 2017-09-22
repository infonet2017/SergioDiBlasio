using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            var PhotoAlb1 = new PhotoAlbum();
            Console.WriteLine("This first album contain " + PhotoAlb1.GetNumberOfPages()+ " pages");

            var PhotoAlb2 = new PhotoAlbum(24);
            Console.WriteLine("This new album contain " + PhotoAlb2.GetNumberOfPages() + " pages");

            var BPhotoAlb1 = new BigPhotoAlbum();
            Console.WriteLine("Thhis Big Album contain " + BPhotoAlb1.GetNumberOfPages() + "pages");

            Console.Write("End of this mega application");
            Console.ReadKey();
        }
    }
}
