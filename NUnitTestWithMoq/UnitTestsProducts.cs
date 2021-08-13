using Models.Classes;
using Models.Interfaces;
using Moq;
using NUnit.Framework;
using NUnitWithMoq.Demo;

namespace NUnitTestWithMoq
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Mocking is creating objects that simulate the behavior of real objects.

        [Test]
        public void ChecksVerifyProductPrice()
        {
            // arrange
            Product cheapProduct = new Product()
            {
                Price = 35
            };

            Mock<IVerifierProductPrice> mock = new Mock<IVerifierProductPrice>();
            mock.Setup(x => x.VerifyProductPrice(cheapProduct)).Returns("Cheap product!");
            VerifierProductPrice checksProductsPrices = new VerifierProductPrice();

            // act
            var expectedResult = mock.Object.VerifyProductPrice(cheapProduct);
            var result = checksProductsPrices.VerifyProductPrice(cheapProduct);

            // assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}