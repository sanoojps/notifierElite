
#region usingDirectives
using System;
using System.Collections.Generic;
using System.Text;

using notifierElite.smb_WebService_Reference;
#endregion

namespace notifierElite
{
    class ConsumeWebService
    {
        ///Instantiate the Webservice
        smb_WebService_Reference.SMBService _SMBService
            = new smb_WebService_Reference.SMBService();
        public ConsumeWebService()
        {
        }

        public void Check_Agent()
        {
            _SMBService.CheckAgentAsync("thangappa", "solve123#");
        }
    }
}
