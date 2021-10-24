using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int ExitCondition =0;
            WelcomeMessage.Welcome();
            int exit = 1;
            while (ExitCondition != exit)
            {
                WelcomeMessage.DisplayMsg();
                int response = Convert.ToInt32(Console.ReadLine());
                if (response >=1 && response <=5 )
                {
                    Console.Clear();

                    switch (response)
                    {
                        case 1:
                            AddNewPerson.AddPerson();
                            Console.WriteLine();
                            break;
                        case 2:
                            AddNewPerson.RemovePerson();
                            break;
                        case 3:
                            AddNewPerson.ListPeople();
                            break;
                        case 4:
                            AddNewPerson.Editperson();
                            break;
                        case 5:
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
            
           
     
