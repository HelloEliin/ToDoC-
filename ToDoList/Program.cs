﻿using System.Security.Cryptography.X509Certificates;

namespace ToDoList
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            



          var json = new CreateToDoListFile();
          json.CreateFile();
          string menuChoice;
          bool isRunning = true;
          string menuTwo;



            do {

                Menu.StartMenu(); 
                menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {

                    
                    case "o":
                        bool isThereAnyLists = Validation.IsThereAnyLists();
                        if (isThereAnyLists == true)
                        {
                            CreateToDoList.RecentList();
                            Menu.ListMenu();
                            string listMenuChoice = Console.ReadLine().ToLower();
                            Menu.ListMenuChoices(listMenuChoice);

                        }
                        break;

                    case "v":

                        isThereAnyLists = Validation.IsThereAnyLists();
                        if (isThereAnyLists == true)
                        {
                            CreateToDoList.ViewAllList();
                            Menu.ListMenu();
                            string listMenuChoice = Console.ReadLine().ToLower();
                            Menu.ListMenuChoices(listMenuChoice);
                        }

                        break;
                    
                   case "c": CreateToDoList.CreateNewToDoList();
                        break;

                   case "d":

                        isThereAnyLists = Validation.IsThereAnyLists();
                        if (isThereAnyLists == true)
                        {
                            CreateToDoList.DeleteList();
                        }
                        break;

                    case "q":
                        Console.WriteLine("Do you want to quit? y/n");
                        string yesOrNo = Console.ReadLine();

                            if (yesOrNo == "y")
                            {
                                isRunning = false;
                            }

                        break;
                        

                    default:
                        Console.WriteLine("Try again.");
                        
                        break;
                }



            } while (isRunning);






        }
    }
}