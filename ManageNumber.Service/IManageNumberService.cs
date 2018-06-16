using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ManageNumber.Service
{
    [ServiceContract]
    public interface IManageNumberService
    {
        [OperationContract]
        double Checkout(string number);
        
        [OperationContract]
        void Checkin(string number);

        [OperationContract]
        int VagasRestantes();

    }

}
