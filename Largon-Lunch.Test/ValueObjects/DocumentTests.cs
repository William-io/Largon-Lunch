using Largon_Lunch.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largon_Lunch.Test
{
    [TestClass]
    public class DocumentTests
    {
        private Document validDocument;
        private Document invalidDocument;

        public DocumentTests()
        {
            validDocument = new Document("05570151460"); //CPF
            invalidDocument = new Document("12345678910"); //Document
        }

        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsNotNotValid()
        {

            Assert.AreEqual(false, invalidDocument.Valid);
            Assert.AreEqual(1, invalidDocument.Notifications.Count);
            //Fazer o teste falhar

        }
        [TestMethod]
        public void ShouldReturnNotificationWhenDocumentIsValid()
        {

            Assert.AreEqual(true, validDocument.Valid);
            Assert.AreEqual(0, validDocument.Notifications.Count);
        }
    }
}
