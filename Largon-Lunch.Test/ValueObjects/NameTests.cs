using Largon_Lunch.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largon_Lunch.Test
{
    [TestClass]
    public class NameTests
    {
        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsNotNotValid()
        {
            var name = new Name("", "Vilela");
            Assert.AreEqual(false, name.Valid);
            Assert.AreEqual(1, name.Notifications.Count);
            //Fazer o teste falhar

        }
    }
}
