using System;
using System.Collections.Generic;
using CalHFAWebAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CalHFAWebAPI
{
    [TestClass]
    public class UnitTests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void ClosingLoansDefaultTest()
        {
            var controller = new ClosingLoans();  
            var response = controller.Get(LoanType.BOTH, new List<int> { 410, 422 }, new List<int> { 510, 522 });
            Assert.IsNotNull(response);

            var jsonResult = (JObject) JsonConvert.DeserializeObject(JsonConvert.SerializeObject(response, Formatting.Indented));

            TestContext.WriteLine(jsonResult.ToString());

            var StatusCodes = jsonResult["Value"].Children();

            foreach (var StatusCode in StatusCodes)
            {
                var statusCode = StatusCode["StatusCode"];
                var statusDate = StatusCode["Date"];
                var statusCount = StatusCode["Count"];

                var switchstatement = (int) statusCode switch
                {
                    410 => new Func<bool>(() => { Assert.AreEqual(statusCount, 5); Assert.AreEqual(statusDate, "2021-07-16"); return true; })(),
                    422 => new Func<bool>(() => { Assert.AreEqual(statusCount, 1); Assert.AreEqual(statusDate, "2021-07-16"); return true; })(),
                    510 => new Func<bool>(() => { Assert.AreEqual(statusCount, 2); Assert.AreEqual(statusDate, "2021-09-16"); return true; })(),
                    522 => new Func<bool>(() => { Assert.AreEqual(statusCount, 1); Assert.AreEqual(statusDate, "2021-08-31"); return true; })(),
                };
            }

        }
    }
}
