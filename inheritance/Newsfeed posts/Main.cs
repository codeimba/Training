using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class TheMain
    {
        public static void Main(string[] args)
        {
            Post post1 = new Post("New update!!!", true, "MartinEmilov96");
            System.Console.WriteLine(post1.ToString());

            ImagePost imageOne = new ImagePost("Check this out!", "MartinEmilov96",
             "https://www.hiveworkshop.com/data/ratory-images/201/201364-74d7a01e189ae854565ab27da6c3d7a3.jpg", true);
            System.Console.WriteLine(imageOne.ToString());
            Console.ReadKey();

        }
    }
}