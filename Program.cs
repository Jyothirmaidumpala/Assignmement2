using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Account
    {
        int Accno;
        string Name;
        string Acctype;
        float Balance;
        public Account(int Accno,string name,string Acctype)
        {
            Accno = Accno;
            Name = name;
            Acctype = Acctype;
        }
        public void Transtype()
        {
            Console.WriteLine("Enter Transaction type:")
                string Transtype = Convert.ToChar(Console.ReadLine());
            if(Transtype =='C')
            {
                Credit;
            }
            else
            {
                Debit;
            }
            public void Credit(int Amount)
            {
                Balance = Balance+Amount;
                Console.WriteLine("Balance After Credited is:{0},\nName{1}", Balance, Name);

            }
            public void Debit(int Amount)
            {
                Balance -= Amount;
                Console.WriteLine("Balance After Deboted is{0},\nName{1}", Balance, Name);
            }
            public void ShowDetails()
            {
                Console.WriteLine("Enter Account Holder Details");
                Console.WriteLine("Account Number:{0)\nName{1}\nAccType{2}", Accno, Name, Acctype);
                Console.WriteLine("AVailable Balance is:{0}", Balance);
                Transtype();
            }
            static void Main()
            {
                Account acc = new Account();
                acc.ShowDetails();
            }
        }

        
    } 
     
}
