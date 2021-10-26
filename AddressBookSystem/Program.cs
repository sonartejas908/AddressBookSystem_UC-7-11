using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int ExitConditionMain = 0;
            AddNewPerson.WelcomeMsgMain();
            int exit = 1;
            while (ExitConditionMain != exit)
            {
                AddNewPerson.DisplayMsgMain();
                int response = Convert.ToInt32(Console.ReadLine());
                if (response >= 1 && response <= 4)
                {
                    Console.Clear();

                    switch (response)
                    {
                        case 1:
                            AddNewPerson.AddAddressBook();
                            Console.WriteLine();
                            break;
                        case 2:

                        case 3:
                            AddNewPerson.ListAddressBook();
                            break;
                        case 4:
                            exit = 0;
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please Enter Valid Input.");
                }

            }

        }
    }
}



