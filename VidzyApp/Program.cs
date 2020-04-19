using Microsoft.Extensions.Configuration;
using System;
using VidzyLibrary.VidzyDbContext;

namespace VidzyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new  VidzyContext()) {
                foreach (var g in dbContext.Genres)
                {
                    Console.WriteLine($"Genre is {g.Name} with id {g.Id}");
                }
                foreach (var video in dbContext.Videos)
                {
                    Console.WriteLine($"Classification is {video.Classification}");
                }
            }
        }
    }
}
