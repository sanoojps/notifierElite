using System;
using System.Collections.Generic;
using System.Text;

using notifierElite.smb_WebService_Reference;

namespace notifierElite
{
    class ConsumeWebService
    {
        public ConsumeWebService()
        {
            ///Instantiate the Webservice
            smb_WebService_Reference.SMBService _SMBService 
                = new smb_WebService_Reference.SMBService();
        }

        public void Check_Agent()
        {

        }
    }
}
