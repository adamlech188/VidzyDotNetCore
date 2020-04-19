using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VidzyLibrary.VidzyDbContext;

namespace UnitTestVidzyApp
{
    [TestClass]
    public  class DbContextTest
    {
        [TestMethod]
        public void Test_DBContext() {
            using (var dbContext = new VidzyContext()) {
               var videos =   dbContext.Videos;
               Assert.IsTrue(videos.Count() > 0);
            }
        }
    }
}
