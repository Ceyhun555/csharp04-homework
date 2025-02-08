﻿using LibraryManegementSystem.Enums;
using LibraryManegementSystem.Managers;
using LibraryManegementSystem.Models;

namespace LibraryManegementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //AuthenticationManager authManager = new AuthenticationManager();

            //authManager.Login();

            //LibraryManager libraryManager = new LibraryManager();

            //LibraryItem bookLibraryItem = libraryManager.CreateNewItem(Enums.ItemType.Book, "Icimizdeki Seytan", "Sabahaddin Ali", 2019, "Turk Edebiyyat Klassikleri");
            //LibraryItem bookLibraryItem2 = libraryManager.CreateNewItem(Enums.ItemType.Book, "Qəzəb Salxımları", "Con Steynbek", 1939, "Azərbaycan Ədəbiyyatı");
            //LibraryItem bookLibraryItem3 = libraryManager.CreateNewItem(Enums.ItemType.Book, "Səfillər", "Viktor Hüqo", 1862, "Fransız Romanı");
            //LibraryItem bookLibraryItem4 = libraryManager.CreateNewItem(Enums.ItemType.Book, "Siçanlar və Adamlar", "Con Steynbek", 1890, "Dünya Povesti");
            //LibraryItem magazineLibraryItem = libraryManager.CreateNewItem(Enums.ItemType.Magazine, "Tech Innovators Monthly", "John Matthews", 2023, "15");
            //LibraryItem magazineLibraryItem1 = libraryManager.CreateNewItem(Enums.ItemType.Magazine, "World Travel Journal", "Emily Parker", 2024, "8");
            //LibraryItem magazineLibraryItem2 = libraryManager.CreateNewItem(Enums.ItemType.Magazine, "Culinary Creations", "Mark Stevens", 2022, "30");
            //LibraryItem articleLibraryItem = libraryManager.CreateNewItem(Enums.ItemType.Article, "The Future of Artificial Intelligence in Healthcare", "Dr. Lisa Hamilton", 2023, " Journal of Medical Innovations");
            //LibraryItem articleLibraryItem1 = libraryManager.CreateNewItem(Enums.ItemType.Article, "Sustainable Practices in Urban Agriculture", " Dr. James Roberts", 2021, "Environmental Sustainability Review");
            //LibraryItem articleLibraryItem2 = libraryManager.CreateNewItem(Enums.ItemType.Article, "Exploring Quantum Computing's Potential", "Dr. Rachel Adams", 2022, " Journal of Advanced Technology");
            //libraryManager.AddItem(bookLibraryItem);
            //libraryManager.AddItem(bookLibraryItem2);
            //libraryManager.AddItem(bookLibraryItem3);
            //libraryManager.AddItem(bookLibraryItem4);
            //libraryManager.AddItem(magazineLibraryItem);
            //libraryManager.AddItem(magazineLibraryItem1);
            //libraryManager.AddItem(magazineLibraryItem2);
            //libraryManager.AddItem(articleLibraryItem);
            //libraryManager.AddItem(articleLibraryItem1);
            //libraryManager.AddItem(articleLibraryItem2);



            /*
             * Step 1: Initialize Managers
             * - Create AuthenticationManager to handle user Login/authentication
             * - Create LibraryManager to manage Library item (books, magazines, articles)
             */

            AuthenticationManager authenticationManager = new AuthenticationManager();
            LibraryManager libraryManager = new LibraryManager();

            /*
             * Step 2: User Authentication Flow
             * - Display welcome message
             * - Handle user login with retry attempts
             * - Show appropriate success/failure messages  
             */

            if (!authenticationManager.Login())
            {
                Console.WriteLine("Login failed. Exiting program.");
                return;
            }

            /*
             * Step 3: Main Application Menu
             * - Show different options based on authentication status
             * - Options include:
             *   > Search items
             *   > Add new items
             *   > Delete items
             *   > View all items
             *   > Logout
             */

            RunMainMenu(libraryManager);

        }

        private static void RunMainMenu(LibraryManager libraryManager)
        {
            bool running = true;

            while (running)
            {
                //Display Menu options

                DisplayMenuOptions();


                // Get User Choice
                if (!int.TryParse(Console.ReadLine(), out int choice) && choice == 0)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    continue;
                }

                //Proces User Choice
                running = ProcessMenuChoice(libraryManager, choice);
            }

        }

        private static bool ProcessMenuChoice(LibraryManager libraryManager, int choice)
        {
            switch (choice)
            {
                case 1: // Add item
                    AddNewItem(libraryManager);
                    return true;
                case 2: // List all item
                    libraryManager.DisplayAllItemInfo();
                    return true;
                case 3: // Search items
                    SearchItems(libraryManager);
                    return true;
                case 4: // Delete an item
                    DeleteItem(libraryManager);
                    return true;
                case 5: // Updating items
                    UpdateItem(libraryManager);
                    return true;
                case 6: // Exit 
                    Console.WriteLine("Thank you for using LMS!");
                    return false;

                default:
                    Console.WriteLine("Invalid choice. Please enter a  number 1 and 5.");
                    return true;
            }
        }

        private static void UpdateItem(LibraryManager libraryManager)
        {
            Console.Write("\nEnter the number of the item to update (or cancel): ");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (choice == 0)
            {
                Console.WriteLine("Update cancelled.");
                return;
            }

            // Get the item to update 
            var itemToUpdate = libraryManager.(choice - 1);

            if (itemToUpdate == null)
            {
                Console.WriteLine("Item not found.");
                return;
            }

            // Now, prompt for updated information
            Console.Write("Enter new title: ");
            string newTitle = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(newTitle))
            {
                newTitle = itemToUpdate.Title;
            }

            Console.Write("Enter new author: ");
            string newAuthor = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(newAuthor))
            {
                newAuthor = itemToUpdate.Author;
            }

            Console.Write("Enter new publish year: ");
            string yearInput = Console.ReadLine();
            int newPublishYear = itemToUpdate.PublishYear;
            if (int.TryParse(yearInput, out int parsedYear))
            {
                newPublishYear = parsedYear;
            }

            // Update the item with new data
            

            
        }

    }

    private static void DeleteItem(LibraryManager libraryManager)
    {
        //Step 1: Display current items
        libraryManager.DisplayAllItemInfo();

        //Step 2: Get items to delete
        Console.Write("\nEnter the number of the item to delete (or cancel): ");

        if (!int.TryParse(Console.ReadLine(), out int choice) && choice < 0)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        //Step 3: Hnadle cancellation
        if (choice == 0)
        {
            Console.WriteLine("Deletion cancelled.");
            return;
        }

        //Step 4: Delete the item 
        libraryManager.DeleteItem(choice - 1);

    }

    private static void SearchItems(LibraryManager libraryManager)
    {
        Console.WriteLine("\nEnter search term (title or author): ");
        string searchTerm = Console.ReadLine() ?? "";

        LibraryItem[] searchResult = libraryManager.SearchItems(searchTerm);

        if (searchResult.Length == 0)
        {
            Console.WriteLine("No items found matching your search.");
            return;
        }

        Console.WriteLine($"\nFound {searchResult.Length} items: ");

        foreach (var libraryItem in searchResult)
        {
            libraryItem.DisplayInfo();
        }
    }

    private static void AddNewItem(LibraryManager libraryManager)
    {
        // Step 1: Get item type
        Console.WriteLine("\n New Item");
        Console.WriteLine("1. Book");
        Console.WriteLine("2. Magazine");
        Console.WriteLine("3. Article");
        Console.Write("\nEnter item type (1-3): ");

        if (!int.TryParse(Console.ReadLine(), out int choice) && choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid item type. Please enter a number between 1 and 3.");
            return;
        }

        ItemType type = (ItemType)choice;

        //Step 2: Get common information
        Console.Write("Enter title: ");
        string title = Console.ReadLine() ?? "";

        Console.Write("Enter author: ");
        string author = Console.ReadLine() ?? "";

        Console.Write("Enter publish year: ");
        if (!int.TryParse(Console.ReadLine(), out int publishYear) && choice == 0)
        {
            Console.WriteLine("Invalid publish year.");
            return;
        }


        // Step 3: Get type-specific information
        string additionalInformation = GetAddItemInfotmation(type);


        //Step 4: Create and the item
        var item = libraryManager.CreateNewItem(
            type: type,
            title: title,
            author: author,
            publishYear: publishYear,
            additionalInfo: additionalInformation
            );

        if (item != null)
        {
            libraryManager.AddItem(item);
        }

    }

    private static string GetAddItemInfotmation(ItemType type)
    {
        switch (type)
        {
            case ItemType.Book:
                Console.Write("Enter genre: ");
                break;
            case ItemType.Magazine:
                Console.Write("Enter issue number: ");
                break;
            case ItemType.Article:
                Console.Write("Enter journal name: ");
                break;

        }

        return Console.ReadLine() ?? "";
    }

    private static void DisplayMenuOptions()
    {
        Console.WriteLine("\nLibrary Management Sytem Menu:");
        Console.WriteLine("1. Add new item");
        Console.WriteLine("2. List all items");
        Console.WriteLine("3. Search items");
        Console.WriteLine("4. Delete an item");
        Console.WriteLine("5. Update items");
        Console.WriteLine("5. Logout and Exit");
        Console.Write("\nEnter your choice (1-5): ");
    }
}





