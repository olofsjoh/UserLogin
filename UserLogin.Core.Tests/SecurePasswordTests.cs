using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserLogin.Core.Tests
{
    [TestClass]
    public class SecurePasswordTests
    {
        [TestMethod]
        public void VerifySecurePassword()
        {
            //Arrange
            var hash = SecurePassword.Hash("sommar03");

            //Act
            var result = SecurePassword.Verify("sommar03", hash);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
