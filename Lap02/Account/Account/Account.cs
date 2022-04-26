using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class Account
    {
        private string AccountID;
        private string FirstName;
        private string LastName;
        private int Balance;

        public Account()
        {
        }
        public Account(string accountID, string firstName, string lastName, int balance)
        {
            AccountID = accountID;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public string AccountID1 { get => AccountID; set => AccountID = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public int Balance1 { get => Balance; set => Balance = value; }

        public void Query()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Account ID: " + AccountID);
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("------------------");
        }
        public void FillInfo()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Account ID: ");
            AccountID = Console.ReadLine();
            Console.WriteLine("First Name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Balance: ");
            Balance = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");
        }
    }
    class AccountList
    {
        private ArrayList list = new ArrayList();
        public void Showlist()
        {
            foreach(Account a in list)
            {
                a.Query();
            }
        }
        public void NewAccount()
        {
            Account a = new Account();
            a.FillInfo();
            list.Add(a);
        }
        public void SaveFile()
        {
            Console.WriteLine("Input file name to save: ");
            string filename = Console.ReadLine();
            try
            {
                FileStream output = new FileStream(filename, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);
                foreach(Account acc in list)
                {
                    writer.WriteLine("{0}, {1}, {2}, {3}", acc.AccountID1, acc.FirstName1, acc.LastName1, acc.Balance1);
                }
                writer.Close();
                output.Close();
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void LoadFile()
        {
            Console.WriteLine("Input file name to load: ");
            string filename = Console.ReadLine();
            list.Clear();
            try
            {
                FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] lists = str.Split(',');
                    Account acc = new Account((lists[0]), lists[1], lists[2], int.Parse(lists[3]));
                    list.Add(acc);
                }
                input.Close();
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Boolean b = true;
            AccountList al = new AccountList();
            while (b)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Save Account");
                Console.WriteLine("3. Load Account");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please choose a number: ");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        al.NewAccount();
                        break;
                    case 2:
                        al.SaveFile();
                        break;
                    case 3:
                        al.LoadFile();
                        al.Showlist();
                        break;
                    case 4:
                        b = false;
                        break;
                }
            }
        }
    }
}
