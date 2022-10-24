using System;

namespace Task_9._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBook photoBook = new PhotoBook();
            Console.WriteLine(photoBook.GetNumberPages());

            PhotoBook photoBook1 = new PhotoBook(24);
            Console.WriteLine(photoBook1.GetNumberPages());

            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook.GetNumberPages());


        }
    }
}
