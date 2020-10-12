using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesIoC.Codes
{
    class IoC02
    {
        public interface ICustomerDataAccess
        {
            string GetCustomerName(int id);
        }

        interface IDataAccessDependency
        {
            void SetDependency(ICustomerDataAccess customerDataAccess);
        }

        public class CustomerDataAccess : ICustomerDataAccess
        {
            public CustomerDataAccess()
            {
            }

            public string GetCustomerName(int id)
            {
                return "Dummy Customer Name";
            }
        }

        public class CustomerBusinessLogic : IDataAccessDependency
        {
            ICustomerDataAccess _dataAccess;

            public CustomerBusinessLogic()
            {
            }

            public string GetCustomerName(int id)
            {
                return _dataAccess.GetCustomerName(id);
            }

            public void SetDependency(ICustomerDataAccess customerDataAccess)
            {
                _dataAccess = customerDataAccess;
            }
        }

        //control of flow calls here
        public class CustomerService
        {
            CustomerBusinessLogic _customerBL;

            public CustomerService()
            {
                _customerBL = new CustomerBusinessLogic();
                ((IDataAccessDependency)_customerBL).SetDependency(new CustomerDataAccess());
            }

            public string GetCustomerName(int id)
            {
                return _customerBL.GetCustomerName(id);
            }
        }

    }
}
