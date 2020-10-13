using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactory.Codes
{
    // factory design pattern
    class Factory01
    {
        public enum CreditCardType
        {
            MoneyBack, Titanium, Platinum
        }

        public interface CreditCard
        {
            string GetCardType();
            int GetCreditLimit();
            int GetAnnualCharge();
        }

        #region Card Types
        class MoneyBack : CreditCard
        {
            public string GetCardType()
            {
                return "MoneyBack";
            }
            public int GetCreditLimit()
            {
                return 15000;
            }
            public int GetAnnualCharge()
            {
                return 500;
            }
        }
        public class Titanium : CreditCard
        {
            public string GetCardType()
            {
                return "Titanium Edge";
            }
            public int GetCreditLimit()
            {
                return 25000;
            }
            public int GetAnnualCharge()
            {
                return 1500;
            }
        }
        public class Platinum : CreditCard
        {
            public string GetCardType()
            {
                return "Platinum Plus";
            }
            public int GetCreditLimit()
            {
                return 35000;
            }
            public int GetAnnualCharge()
            {
                return 2000;
            }
        }
        #endregion

        #region Factory
        internal class CreditCardFactory
        {
            public static CreditCard GetCreditCard(CreditCardType cardType)
            {
                CreditCard cardDetails = null;
                switch (cardType)
                {
                    case CreditCardType.MoneyBack:
                        cardDetails = new MoneyBack();
                        break;
                    case CreditCardType.Titanium:
                        cardDetails = new Titanium();
                        break;
                    case CreditCardType.Platinum:
                        cardDetails = new Platinum();
                        break;
                    default:
                        break;
                }
                return cardDetails;
            }
        } 
        #endregion


        internal static void Call()
        {
            Console.WriteLine("Factory Pattern");

            CreditCard cardDetails = CreditCardFactory.GetCreditCard(CreditCardType.MoneyBack);

            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
        }
    }
}
