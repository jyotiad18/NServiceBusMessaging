using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using NServiceBus.MessageMutator;
using NServiceBus;


namespace NServiceBusMessaging.Authentication
{
    public class AccessTokenMutuer : IMutateOutgoingTransportMessages
    {
        public Task MutateOutgoing(MutateOutgoingTransportMessageContext context)
        {

            context.OutgoingHeaders["test_token"] = HttpContext.Current.Request.Params["test_token"];
            return Task.FromResult(0);
            
           
        }
       
    }
}