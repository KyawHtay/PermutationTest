using NUnit.Framework;
using PermutationTest;
using PermutationTest.Controllers;

namespace PermutationUnitTests
{
    public class PermutationUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Permute_Ispotstop_Pass()
        {
            string str = "potspot";

            int n = str.Length;
            Permutation _permute = new Permutation(false);
            bool isFound = _permute.permute(str, 0, n - 1, "potstop");
            Assert.IsTrue(isFound);

        }

        [Test]
        public void GetPermute_Ispotstop_Pass()
        {
            string str = "potspot";
            WebAPIController controller = new WebAPIController();
            bool isFound = controller.GetPermute(str, "potstop");
            Assert.IsTrue(isFound);

        }

        [Test]
        public void GetPermute_NotIspotstopp_Pass()
        {
            string str = "potspot";
            WebAPIController controller = new WebAPIController();
            bool isFound = controller.GetPermute(str, "potstopp");
            Assert.IsFalse(isFound);

        }
    }
}
}