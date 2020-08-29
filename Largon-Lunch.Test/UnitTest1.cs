using Largon_Lunch.Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largon_Lunch.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "William",
                "Vilela", 
                "702103", 
                "capuletos@live.com",
                "8587356754", 
                "Montese");

            //c.FirstName = "";
        }
    }
}
