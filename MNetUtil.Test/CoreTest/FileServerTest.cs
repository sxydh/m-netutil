using Microsoft.VisualStudio.TestTools.UnitTesting;
using MNetUtil.Core;

namespace MNetUtil.Test.CoreTest
{
    [TestClass]
    public class FileServerTest
    {
        [TestMethod]
        public void TestNew()
        {
            FileServer fileServer = new FileServer(8080, "");
            fileServer.Start().Wait();
        }

    }
}
