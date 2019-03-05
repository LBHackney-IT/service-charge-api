using NUnit.Framework;
using ServiceChargeAPI.V1.Domain;
using ServiceChargeAPI.V1.Factory;

namespace UnitTests.V1.Factories
{
    [TestFixture]
    public class TransactionFactoryTest
    {
        [Test]
        public void CanBeCreatedFromUhTransactions()
        {
            var uhTransaction = new UhTransaction();

            var transaction = new TransactionFactory().FromUhTransaction(uhTransaction);

            Assert.AreEqual(uhTransaction.Balance,transaction.Balance);
            Assert.AreEqual(uhTransaction.Code,transaction.Code);
            Assert.AreEqual(uhTransaction.Date,transaction.Date);
        }
    }
}
