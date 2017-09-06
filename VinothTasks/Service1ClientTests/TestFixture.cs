using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.ServiceModel;

namespace Service1ClientTests
{
    [TestFixture]
    public class ServiceClientTests
    {
        private TaskWebService.Service1 client;
        [TestFixtureSetUp]
        public void Initialize()
        {
            this.client = new TaskWebService.Service1();
        }
        [Test]
        public void FibonacciTest()
        {
            Assert.AreEqual("Fibonacci (101) is -1", client.Fibonacci(101));
            Assert.AreEqual("Fibonacci (0) is 0", client.Fibonacci(0));
            Assert.AreEqual("Fibonacci (1) is 1", client.Fibonacci(1));
            Assert.AreEqual("Fibonacci (50) is 12586269025", client.Fibonacci(50));
        }
        [Test]
        public void XMLToJsonTest()
        {
            Assert.AreEqual("Bad XML Format", client.XmlToJson("<foo>hello</bar>"));
            Assert.AreEqual("{ \"foo\": {\"value\": \"hello\" }}", client.XmlToJson("<foo>hello</foo>"));
            
        }
    }
}
