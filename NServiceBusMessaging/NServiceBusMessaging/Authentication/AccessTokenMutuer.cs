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
            
            throw new NotImplementedException();
        }
       
    }
}