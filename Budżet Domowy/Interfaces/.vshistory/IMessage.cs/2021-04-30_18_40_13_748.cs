using System;
using System.Collections.Generic;
using System.Text;
using Budżet_Domowy.Classes;

namespace GRUPA_K13.Interfaces
{
    public interface IMessage
    {
        IMessage ProcessRequest(StateObject a_oStateObject = null);
        IMessage ProcessResponse(StateObject a_oStateObject = null);
    }
}
