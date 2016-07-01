using System.Collections.Generic;
using System.Collections;
using System;

namespace XendApi.Interface
{
    public  interface IAuthenticate
    {
        string XKey {  set; }

        string XPass {  set; }

        Uri UrlEndPoint { set; }

        string Authenticate();
    }
}
