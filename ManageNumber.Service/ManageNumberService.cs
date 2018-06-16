using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ManageNumber.Service
{
    public class ManageNumberService : IManageNumberService
    {
        public double Checkout(string number)
        {
            return ManageNumber.Business.Operations.Checkout(number);
        }

        public void Checkin(string number)
        {
            ManageNumber.Business.Operations.Checkin(number);
        }

        public int VagasRestantes()
        {
            return ManageNumber.Business.Operations.TOTAL_NUMBERS - ManageNumber.Business.Operations._ManageNumber.Count();
        }
        
    }
}
