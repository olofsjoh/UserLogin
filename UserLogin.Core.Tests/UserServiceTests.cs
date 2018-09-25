using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UserLogin.Core.Interfaces;

namespace UserLogin.Core.Tests
{
    [TestClass]
    public class UserServiceTests
    {
        private Mock<IUserRepository> _userRepositoryMock = new Mock<IUserRepository>();
        private Mock<ILogger> _logger = new Mock<ILogger>();
        private UserService _userService;

        [TestInitialize]
        public void Init()
        {
            _userService = new UserService(_userRepositoryMock.Object, _logger.Object);
        }

        [TestMethod]
        public void GivenEmptyUserName_ThenHasValidCredentialsShouldReturnFalse()
        {
            // Act
            var hasValidCreddentials = _userService.HasValidCredentials("", "123");

            // Assert
            Assert.IsFalse(hasValidCreddentials);
        }

        [TestMethod]
        public void GivenEmptyPassword_ThenHasValidCredentialsShouldReturnFalse()
        {
            // Act
            var hasValidCreddentials = _userService.HasValidCredentials("joe", "");

            // Assert
            Assert.IsFalse(hasValidCreddentials);
        }

        [TestMethod]
        public void GivenNotFoundUserName_ThenHasValidCredentialsShouldReturnFalse()
        {
            // Arrange
            _userRepositoryMock.Setup(x => x.GetUser(It.IsAny<string>())).Returns((Model.User)null);

            // Act
            var hasValidCreddentials = _userService.HasValidCredentials("joe", "123");

            // Assert
            Assert.IsFalse(hasValidCreddentials);
        }

        [TestMethod]
        public void GivenNotValidPasswordCredentials_ThenHasValidCredentialsShouldReturnFalse()
        {
            // Arrange
            var hashedPassword = SecurePassword.Hash("sommar03");
            _userRepositoryMock.Setup(x => x.GetUser(It.IsAny<string>())).Returns(new Model.User { UserName = "karl", Password = hashedPassword });

            // Act
            var hasValidCreddentials = _userService.HasValidCredentials("joe", "sommar05");

            // Assert
            Assert.IsFalse(hasValidCreddentials);
        }

        [TestMethod]
        public void GivenValidPasswordCredentials_ThenHasValidCredentialsShouldReturnTrue()
        {
            // Arrange
            var hashedPassword = SecurePassword.Hash("sommar03");
            _userRepositoryMock.Setup(x => x.GetUser(It.IsAny<string>())).Returns(new Model.User { UserName = "karl", Password = hashedPassword });

            // Act
            var hasValidCreddentials = _userService.HasValidCredentials("karl", "sommar03");

            // Assert
            Assert.IsTrue(hasValidCreddentials);
        }
    }
}
