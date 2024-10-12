using Microsoft.VisualStudio.TestTools.UnitTesting;
using MNetUtil.Core;
using System.Threading.Tasks;

namespace MNetUtil.Test.Core
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
