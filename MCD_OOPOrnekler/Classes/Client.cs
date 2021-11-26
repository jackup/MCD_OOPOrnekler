using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPOrnekler.Classes
{
    class Client
    {
        #region Properties
        public int clientId { get; set; }
        public string clientName { get; set; }
        public string clientSurname { get; set; }
        public DateTime birthDate { get; set; }
        public Genders gender { get; set; }
        public ProductBasket clientBasket { get; set; }

        #endregion

        
        #region Methods

        public bool IsBirthDate()
        {
            bool kontrol = false;
            kontrol = (birthDate.Day == DateTime.Now.Day && birthDate.Month == DateTime.Now.Month) ? true : false;

            return kontrol;
        }
        public void PrintClientInformations()
        {
            Console.WriteLine($"Müşteri No: {clientId} - {clientName} {clientSurname}");
        }
        public void PrintClientBasket()
        {
            //if (clientBasket.)
            //{

            //}
        }
        #endregion
    }
}
