using XendApi.Configuration;
using XendApi.Interface;

namespace XendApi.Infrastructure.Authentication
{
    public class XendCredential : IXendCredentials
    {
        public string XKey
        {
            get
            {
                return XENDENDPOINTCONFIG.XEND_XKEY;
            }
        }

        public string Xpass
        {
            get
            {
#if DEBUG
                return XENDENDPOINTCONFIG.XEND_TEST_XPASS;
#else
                return XENDENDPOINTCONFIG.XEND_PRODUCTION_XPASS;
#endif
            }
        }

        public string MyXendAccount
        {
            get
            {
                return XENDENDPOINTCONFIG.XEND_ACCOUNT_NUMBER;
            }
        }

        public string AppId
        {
            get
            {
#if DEBUG
                return XENDENDPOINTCONFIG.XEND_TEST_APP_ID;
#else 
                return  XENDENDPOINTCONFIG.XEND_PRODUCTION_APP_ID;
#endif
            }
        }


    }
}
