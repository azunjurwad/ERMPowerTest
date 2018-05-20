using ERMPowerTest.Contracts;
using ERMPowerTest.Environment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace ERMPowerTest.Steps
{
    [Binding]
    public class APITestsSteps
    {

        public static RootObject[] loginObjects;
        public int TypeId;

        [Given(@"I get all login objects from the web service")]
        public void GivenIGetAllLoginObjectsFromTheWebService(Table apiTable)
        {
            foreach (var row in apiTable.Rows)
            {
                var rootObjects = new TypeCode();
                loginObjects = ScenarioContext.Current.GetHttpClient().LastResponseAs<RootObject[]>(row["ApiUrl"]);
            }
        }

        [When(@"I provide Id '(.*)' to get specific login details")]
        public void WhenIProvideIdToGetSpecificLoginDetails(int id)
        {
            TypeId = id;
        }

        [Then(@"I should receive correct login details")]
        public void ThenIShouldReceiveCorrectLoginDetails(Table expectedLoginDetailsTable)
        {
            var rootObjects = new TypeCode();
            var userId = rootObjects.GetUserId(loginObjects, TypeId);
            var title = rootObjects.GetTitle(loginObjects, TypeId);
            var body = rootObjects.GetBody(loginObjects, TypeId);
            foreach (var expectedLoginRow in expectedLoginDetailsTable.Rows)
            {
                Assert.AreEqual(expectedLoginRow["userId"], userId.ToString());
                Assert.AreEqual(expectedLoginRow["title"], title);
                Assert.AreEqual(expectedLoginRow["body"], body);
            }
        }

        [Then(@"I should get '(.*)' number of records")]
        public void ThenIShouldGetNumberOfRecords(int recordNumbers)
        {
            Assert.AreEqual(recordNumbers, loginObjects.Length);
        }
    }
}
