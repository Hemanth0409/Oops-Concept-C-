using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    public class CreditCard
    {
        public int CreditCardNumber { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public int Cvv { get; set; }
    }
    public class DebitCard
    {
        public int DebitCardNumber { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public int Cvv { get; set; }
    }
    public class NetBanking
    {
        public int AccountNumber { get; set; }
        public int CFINumber { get; set; }
        public int BranchCode { get; set; }
    }
    public class PaymentInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Amount { get; set; }
    }
    public class Paypal
    {     
        public int AccountNumber { get; set; }
        public int cvv { get; set; }

    }

    public abstract class AbstractionPayment
    {
        public int UserId;
        public string UserName;
        public int Amount;

        public AbstractionPayment(int id, string userName)
        {
            UserId = id;
            UserName = userName;

        }
        public abstract void PaymentMethod();
    }

    
    public class CreditCardPayment : AbstractionPayment
    {
        private CreditCard _credit { get; set; }

        public CreditCardPayment(string userName, int id, CreditCard credit) : base(id, userName)
        {
            _credit = credit;
        }



        public override void PaymentMethod()
        {
            Console.WriteLine($"UserId:{UserId},UserName:{UserName},CreditCard Number:{_credit.CreditCardNumber},Expiration Month:{_credit.ExpirationMonth},Expiration Year:{_credit.ExpirationYear},Cvv Number:{_credit.Cvv}");

        }


    }
    public class DebitCardPayment : AbstractionPayment
    {
        private DebitCard _debit { get; set; }

        public DebitCardPayment(string userName, int id, DebitCard debit) : base(id, userName)
        {
            _debit = debit;
        }
        public override void PaymentMethod()
        {
            Console.WriteLine($"UserId:{UserId},UserName:{UserName},CreditCard Number:{_debit.DebitCardNumber},Expiration Month:{_debit.ExpirationMonth},Expiration Year:{_debit.ExpirationYear},Cvv Number:{_debit.Cvv}");

        }
    }
    public class NetBankingPayment : AbstractionPayment
    {
        private NetBanking _netBanking { get; set; }
        public NetBankingPayment(string userName, int id, NetBanking netBanking) : base(id, userName)
        {
            _netBanking = netBanking;
        }
        public override void PaymentMethod()
        {
            Console.WriteLine($"UserId:{UserId},UserName:{UserName},Account Number:{_netBanking.AccountNumber},CFI number:{_netBanking.CFINumber},Branch Code:{_netBanking.BranchCode}");
        }
    }
    public class PaypalPayment : AbstractionPayment
    {
        private Paypal _paypal{ get; set; }
        public PaypalPayment(string userName, int id, Paypal paypal) : base(id, userName)
        {
            _paypal = paypal;
        }
        public override void PaymentMethod()
        {
            Console.WriteLine($"UserId:{UserId},UserName:{UserName},Account Number:{_paypal.AccountNumber},CVV Number:{_paypal.cvv}");
        }
    }
    public class MainPayment
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Press 1:Credit Card Payment");
            Console.WriteLine("Press 2:Debit Card Payment");
            Console.WriteLine("Press 3:Net Banking Payment");
            Console.WriteLine("Press 4:Paypal Payment");



            Console.WriteLine("Enter the mode of payment: ");
            int paymentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Id");
            int userId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter your Name:");
            string userName = Console.ReadLine();
            Console.WriteLine();

            switch (paymentId)
            {
                case 1:

                    Console.Write("Enter the CreditCardNumber:");
                    int CardNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter the Expiration Month:");
                    int ExpirationMonth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter the Expiration Year:");
                    int ExpirationYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter the Cvv Number:");
                    int Cvv = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    AbstractionPayment creditCardTransaction = new CreditCardPayment(userName, userId, new CreditCard { CreditCardNumber = CardNumber, ExpirationMonth = ExpirationMonth, ExpirationYear = ExpirationYear, Cvv = Cvv });
                    creditCardTransaction.PaymentMethod();
                    break;
                case 2:

                    Console.Write("Enter the DebitCardNumber:");
                    int debitCardNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter the Expiration Month:");
                    int debitExpirationMonth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter the Expiration Year:");
                    int debitExpirationYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter the Cvv Number:");
                    int debitCvv = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    AbstractionPayment debitCardTransaction = new DebitCardPayment(userName, userId, new DebitCard { DebitCardNumber = debitCardNumber, ExpirationMonth = debitExpirationMonth, ExpirationYear = debitExpirationYear, Cvv = debitCvv });
                    debitCardTransaction.PaymentMethod();
                    break;
                case 3:
                    Console.Write("Enter the Account Number:");
                    int AccountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter the CFI Number:");
                    int CFInumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter the BranchCode:");
                    int BranchCode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    AbstractionPayment netBanking = new NetBankingPayment(userName, userId, new NetBanking { AccountNumber = AccountNumber, CFINumber = CFInumber, BranchCode = BranchCode });
                    netBanking.PaymentMethod();
                    break;
                case 4:
                    Console.Write("Enter the Account Number:");
                    int AccountNumberPaypal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter the cvv Number:");
                    int cvv = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    AbstractionPayment paypal = new PaypalPayment(userName, userId, new Paypal { AccountNumber = AccountNumberPaypal,cvv=cvv });
                    paypal.PaymentMethod();
                    break;

            }

        }

    }
}

