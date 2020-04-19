using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using VidzyLibrary.VidzyDbContext;

namespace UnitTestVidzyApp
{
    [TestClass]
    public class ClassificationTest
    {
        [TestMethod]
        public void Test_Classification() {
            using (var dbContext = new VidzyContext()) {
                var videos = dbContext.Videos;
                foreach(var video in videos) {
                    System.Diagnostics.Debug.WriteLine($"Classification is {video.Classification}");
                }
            }
         
        }
    }
}
