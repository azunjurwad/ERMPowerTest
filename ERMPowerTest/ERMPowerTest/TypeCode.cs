/*
 *Author: Abhishek Zunjurwad
 */

using ERMPowerTest.Contracts;

namespace ERMPowerTest
{
    public class TypeCode
    {
        public int GetUserId(RootObject[] loginObjects, int id)
        {
            int userId = int.MinValue;
            foreach (var loginObject in loginObjects)
            {
                if (loginObject.Id == id)
                {
                    userId = loginObject.UserId;
                }
            }
            return userId;
        }

        public string GetTitle(RootObject[] loginObjects, int id)
        {
            string title = string.Empty;
            foreach (var loginObject in loginObjects)
            {
                if (loginObject.Id == id)
                {
                    title = loginObject.Title;
                }
            }
            return title;
        }

        public string GetBody(RootObject[] loginObjects, int id)
        {
            string body = string.Empty;
            foreach (var loginObject in loginObjects)
            {
                if (loginObject.Id == id)
                {
                    body = loginObject.Body;
                }
            }
            return body;
        }
    }
}
