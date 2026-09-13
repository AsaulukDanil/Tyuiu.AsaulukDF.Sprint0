using Tyuiu.AsaulukDF.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AsaulukDF.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            string name = "Данил";
            string res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Данил", res);
        }
    }
}