using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvcClassroom.Controllers;
using MvcClassroom.Data;

namespace TestMvcClassroom1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<MvcClassroomContext> mock = new Mock<MvcClassroomContext>();
            ClassesController classesController = new ClassesController(mock.Object);
            Microsoft.AspNetCore.Mvc.IActionResult actionResult = classesController.Create();
            Assert.IsNotNull(actionResult);
            Assert.IsInstanceOfType(actionResult, typeof(ViewResult));
        }
    }
}
