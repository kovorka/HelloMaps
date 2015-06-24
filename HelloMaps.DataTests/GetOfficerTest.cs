using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using HelloMaps.Data;
using HelloMaps.Entities;

namespace HelloMaps.DataTests
{
    [TestClass]
    public class GetOfficerTest
    {
        [TestMethod]
        public void GetOfficerIsNotNull()
        {
            var service = new DataService();
            List<Officer> result = service.GetOfficersBySuburb(null);
            Assert.IsNotNull(result);
        }
    }
}
