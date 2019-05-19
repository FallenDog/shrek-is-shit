using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1.Contract
{

    [ServiceContract]
    interface IGameDev
    {
        [OperationContract]
        void AddGame();
        [OperationContract]
        void DelGame();

    }
}
