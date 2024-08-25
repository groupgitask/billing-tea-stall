using System;
namespace name
{
    class amoga
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("     BALLE BALLE DABHA     ");
            Console.WriteLine("***********");
            Console.WriteLine("             Menu        ");
            Console.WriteLine("***********");
            Console.WriteLine("press     product        price");
            Console.WriteLine("1          chai            15");
            Console.WriteLine("2          coffee          20");
            Console.WriteLine("3          Lemon tea       30");
            Console.WriteLine("4          Badam milk      40");
            Console.WriteLine("5          Sandwich        65");
            Console.WriteLine("6          burger          80");
            Console.WriteLine("7          Pizza           120");
            Console.WriteLine("***********");

            double discount = 0;
            double finalamount = 0;
            double billamt = 0;

            bool continueOrdering = true;

            while (continueOrdering)
            {
                Console.Write("Enter your choice here: ");
                int choice = int.Parse(Console.ReadLine());

                Console.Write("Enter Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        billamt += quantity * 15;
                        break;
                    case 2:
                        billamt += quantity * 20;
                        break;
                    case 3:
                        billamt += quantity * 30;
                        break;
                    case 4:
                        billamt += quantity * 40;
                        break;
                    case 5:
                        billamt += quantity * 65;
                        break;
                    case 6:
                        billamt += quantity * 80;
                        break;
                    case 7:
                        billamt += quantity * 120;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.Write("Do you want to add more items? (yes/no): ");
                string response = Console.ReadLine().ToLower();

                if (response != "yes")
                {
                    continueOrdering = false;
                }
            }

            string time2 = DateTime.Now.ToString("T");
            string daten = DateTime.Now.ToString("d");
            string time1 = time2.Substring(0, 2);
            int time = Convert.ToInt32(time1);
            Random random = new Random();
            int tran = random.Next(100, 200);
            long tran1 = tran * 123456;
            Console.WriteLine("***********");
            Console.WriteLine("\t" + "\t" + "Time " + time2);
            Console.WriteLine("\t" + "\t" + "Date " + daten);
            Console.WriteLine("\t" + "\t" + "Transction Id  " + tran);

            if (billamt >= 300)
            {
                discount = billamt * 0.20; // 20% discount
                finalamount = billamt - discount;
                Console.WriteLine("Bill Amount: " + billamt);
                Console.WriteLine("Discount: " + discount);
                Console.WriteLine("Final Amount to pay: " + finalamount);
            }
            else
            {
                finalamount = billamt;
                Console.WriteLine("Bill Amount: " + billamt);
                Console.WriteLine("No discount applicable");
                Console.WriteLine("Final Amount to pay: " + finalamount);
            }

            Console.WriteLine("***********");
            Console.Write("Amount paid: ");
            double amtpaid = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***********");

            if (amtpaid > finalamount)
            {
                double balance = amtpaid - finalamount;
                Console.WriteLine("Balance: " + balance);
            }
            else if (amtpaid < finalamount)
            {
                double balance = finalamount - amtpaid;
                Console.WriteLine("More amount needs to be paid: " + balance);
            }
            else
            {
                Console.WriteLine("All clear");
            }
        }
    }
}