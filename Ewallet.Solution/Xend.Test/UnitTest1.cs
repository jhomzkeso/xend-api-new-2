using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xend.Utilities;
using XendApi.Configuration;
using XendApi.Infrastructure.Addresses;
using XendApi.Infrastructure.Authentication;
using XendApi.Interface;

namespace Xend.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string tobeHashed = XENDENDPOINTCONFIG.XEND_ACCOUNT_NUMBER + XENDENDPOINTCONFIG.XEND_TEST_APP_ID;

            XKeyHash X = new XKeyHash();
           var result = X.Hash(tobeHashed);

        }


        [TestMethod]
        public void TestMethod2()
        {
            IXendCredentials credential = new XendCredential();

            XendAuthenticate x = new XendAuthenticate(credential);
            x.Authenticate();

        }


        [TestMethod]
        public void TestMethod3()
        {
            IXendCredentials credentials =  new XendCredential();
            IAuthenticate x = new XendAuthenticate(credentials);
            IRequestAddress address = new XendAddressRequest(x);


            var provinces = address.GetProvince();
            var cities = address.GetCities(48);

        }
    }
}
