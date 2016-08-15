using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greetings.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Greeting.Api.Controllers;

namespace Greeting.Api.Tests.Controllers
{
    [TestClass]
    public class GreetinsControllerTests
    {
        [TestMethod]
        public void Index()
        {
            IMessageRepository repository = new MessageRepository();

            GreetingsController controller = new GreetingsController();

            Assert.AreEqual("Hello World", controller.Get());
                 
            
        }
    }
}
