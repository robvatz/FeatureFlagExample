using System;
using System.Web.Mvc;
using FeatureFlagExample.Controllers;
using NUnit.Framework;

namespace FeatureFlagExample.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        private FakeFeatureStatuses _menuSetting; 

        [SetUp]
        public void SetUp()
        {
            _menuSetting = new FakeFeatureStatuses();
        }

        [TearDown]
        public void TearDown()
        {
            _menuSetting = null;
        }

        [Test]
        public void Index()
        {
            // Arrange
            _menuSetting.ShowNewMenu = false;
            var controller = new HomeController(_menuSetting);

            // Act
            var result = controller.Index();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.IsInstanceOf<ViewResult>(result);
            var result2 = (ViewResult)result;
            Assert.IsEmpty(result2.ViewBag.Message, "message");
            Assert.AreEqual(false, result2.ViewBag.ExtraMenuFeature, "extra menu feature flag");
        }

        [Test]
        public void About()
        {
            // Arrange
            _menuSetting.ShowNewMenu = false;
            var controller = new HomeController(_menuSetting);

            // Act
            var result = controller.About();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsEmpty(result.ViewBag.Message, "message");
            Assert.AreEqual(false, result.ViewBag.ExtraMenuFeature, "extra menu feature flag");
        }

        [Test]
        public void Contact()
        {
            // Arrange
            _menuSetting.ShowNewMenu = false;
            var controller = new HomeController(_menuSetting);

            // Act
            var result = controller.Contact();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsEmpty(result.ViewBag.Message, "message");
            Assert.AreEqual(false, result.ViewBag.ExtraMenuFeature, "extra menu feature flag");
        }

        [Test]
        public void IndexWithNewPage()
        {
            // Arrange
            _menuSetting.ShowNewMenu = true;
            var controller = new HomeController(_menuSetting);

            // Act
            var result = controller.Index();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.IsInstanceOf<ViewResult>(result);
            var result2 = (ViewResult)result;
            Assert.IsEmpty(result2.ViewBag.Message, "message");
            Assert.AreEqual(true, result2.ViewBag.ExtraMenuFeature, "extra menu feature flag");
        }

        [Test]
        public void NewPage()
        {
            // Arrange
            _menuSetting.ShowNewMenu = true;
            var controller = new HomeController(_menuSetting);

            // Act
            var result = controller.NewPage();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsEmpty(result.ViewBag.Message, "message");
            Assert.AreEqual(true, result.ViewBag.ExtraMenuFeature, "extra menu feature flag");
        }

        [Test]
        public void IndexViaDefaultConstructor()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.IsInstanceOf<ViewResult>(result);
            var result2 = (ViewResult)result;
            Assert.IsEmpty(result2.ViewBag.Message, "message");
            Assert.AreEqual(false, result2.ViewBag.ExtraMenuFeature, "extra menu feature flag");
        }

        [Test]
        public void ThrowAnException_ShouldThrowAnException()
        {
            var controller = new HomeController();

            Assert.Throws<NotImplementedException>(() => controller.ThrowAnException());
        }
    }
}
