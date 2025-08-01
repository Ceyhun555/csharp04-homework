﻿using LMSWithArrayListPractice.Enums;
using LMSWithArrayListPractice.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSWithArrayListPractice.Managers
{
    public class LibraryManager
    {
        #region Fields
        private readonly ArrayList  _libraryItems;
        #endregion

        #region Constructor
        
        public LibraryManager()
        {
            _libraryItems = new ArrayList();
            
        }
        #endregion

        #region Public Methods
        
        public void RunMainMenu()
        {
            bool running = true;

            while (running)
            {
                DisplayMenuOptions();
                int choice = GetUserChoice();
                running = ProcessMenuChoice(choice);
            }
        }

        public bool AddItem(LibraryItem item)
        {
            // Validate the item before adding
            if (!ValidateItem(item)) return false;

            // Add item to the array and increment the item count
            _libraryItems.Add(item);
            Console.WriteLine("Item added successfully");
            return true;
        }

        public void DisplayAllItemInfo()
        {
            if (_libraryItems.Count == 0)
            {
                Console.WriteLine("Error: No items in library");
                return;
            }

            Console.WriteLine("\nLibrary Items:");
            for (int i = 0; i < _libraryItems.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                ((LibraryItem)_libraryItems[i]).DisplayInfo();
            }
        }

        public ArrayList SearchItems(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                Console.WriteLine("Search term cannot be empty.");
                return new ArrayList();
            }

            searchTerm = searchTerm.Trim().ToLower();
            ArrayList matchingItems = new ArrayList();
            int matchCount = 0;

            for (int i = 0; i < _libraryItems.Count; i++)
            {
                LibraryItem item = ((LibraryItem)_libraryItems[i]);
                if (item != null &&
                    (item.Title.ToLower().Contains(searchTerm) ||
                     item.Author.ToLower().Contains(searchTerm)))
                {
                    matchingItems.Add(item);
                }
            }

            

            return matchingItems;
        }

        public bool DeleteItem(int index)
        {
            // Validate the index before deleting
            if (!ValidateIndex(index)) return false;

            _libraryItems.RemoveAt(index);
            
            Console.WriteLine("Item deleted successfully");
            return true;
        }

        public bool UpdateItem(int index, string newTitle, string newAuthor, int newPublishYear, string newAdditionalInfo)
        {
            if (!ValidateIndex(index) || !ValidateItemDetails(newTitle, newAuthor, newPublishYear)) return false;

            LibraryItem item = (LibraryItem)_libraryItems[index];
            item.UpdateDetails(newTitle, newAuthor, newPublishYear);

            switch (item)
            {
                case Book book:
                    if (!ValidateAdditionalInfo(newAdditionalInfo, "Genre cannot be empty for books.")) return false;
                    book.UpdateGenre(newAdditionalInfo);
                    break;

                case Magazine magazine:
                    if (!ValidateAdditionalInfo(newAdditionalInfo, "Invalid issue number for magazines.", out int issueNumber) || issueNumber <= 0) return false;
                    magazine.UpdateIssueNumber(issueNumber);
                    break;

                case Article article:
                    if (!ValidateAdditionalInfo(newAdditionalInfo, "Journal name cannot be empty for articles.")) return false;
                    article.UpdateJournalName(newAdditionalInfo);
                    break;

                default:
                    Console.WriteLine("Error: Unknown item type.");
                    return false;
            }

            Console.WriteLine("Item updated successfully.");
            return true;
        }

        public LibraryItem CreateNewItem(ItemType type, string title, string author, int publishYear, string additionalInfo)
        {
            if (!ValidateItemDetails(title, author, publishYear)) return null;

            switch (type)
            {
                case ItemType.Book:
                    if (ValidateAdditionalInfo(additionalInfo, "Genre cannot be empty."))
                        return new Book(title, author, publishYear, additionalInfo);
                    break;

                case ItemType.Magazine:
                    if (ValidateAdditionalInfo(additionalInfo, "Invalid issue number.", out int issueNumber) && issueNumber > 0)
                        return new Magazine(title, author, publishYear, issueNumber);
                    break;

                case ItemType.Article:
                    if (ValidateAdditionalInfo(additionalInfo, "Journal name cannot be empty."))
                        return new Article(title, author, publishYear, additionalInfo);
                    break;
            }

            return null;
        }
        #endregion

        #region Private Methods
        private void DisplayMenuOptions()
        {
            Console.WriteLine("\nLibrary Management System Menu:");
            Console.WriteLine("1. Add new item");
            Console.WriteLine("2. List all items");
            Console.WriteLine("3. Search items");
            Console.WriteLine("4. Delete an item");
            Console.WriteLine("5. Update an item");
            Console.WriteLine("6. Logout and Exit");
            Console.Write("\nEnter your choice (1-6): ");
        }

        private bool ProcessMenuChoice(int choice)
        {
            switch (choice)
            {
                case Constant.MenuOptions.AddItem:
                    AddNewItem();
                    return true;
                case Constant.MenuOptions.ListItems:
                    DisplayAllItemInfo();
                    return true;
                case Constant.MenuOptions.SearchItems:
                    SearchItems();
                    return true;
                case Constant.MenuOptions.DeleteItem:
                    DeleteItem();
                    return true;
                case Constant.MenuOptions.UpdateItem:
                    UpdateItem();
                    return true;
                case Constant.MenuOptions.Exit:
                    Console.WriteLine("Thank you for using LMS!");
                    return false;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    return true;
            }
        }

        private void AddNewItem()
        {
            Console.WriteLine("\nNew Item");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Magazine");
            Console.WriteLine("3. Article");
            Console.WriteLine("4. Cancel");
            Console.Write("\nEnter item type (1-3): ");
            int choice = GetUserChoice();

            if (choice == 4)
            {
                Console.WriteLine("Add item cancelled.");
                return;
            }

            ItemType type = (ItemType)choice;

            string title = GetInput("Enter title: ");
            string author = GetInput("Enter author: ");
            int publishYear = GetValidatedYear("Enter publish year: ");
            string additionalInformation = GetAdditionalInformation(type);

            var item = CreateNewItem(type, title, author, publishYear, additionalInformation);

            if (item != null)
            {
                AddItem(item);
            }
            else
            {
                Console.WriteLine("Error: Item creation failed.");
            }
        }

        private int GetValidatedYear(string prompt)
        {
            string userInput = GetInput(prompt);
            int year;

            while (!int.TryParse(userInput, out year) || year < 1000 || year > DateTime.Now.Year)
            {
                Console.WriteLine("Invalid year. Please enter a valid year between 1000 and the current year.");
                userInput = GetInput(prompt);
            }

            return year;
        }

        private void UpdateItem()
        {
            DisplayAllItemInfo();
            Console.Write("Enter the number of the item to update (or 0 to cancel): ");
            int index = GetUserChoice() - 1;
            if (index < 0)
            {
                Console.WriteLine("Update cancelled.");
                return;
            }

            string newTitle = GetInput("Enter new title: ");
            string newAuthor = GetInput("Enter new author: ");
            int newPublishYear = GetValidatedYear("Enter new publish year: ");
            string newAdditionalInfo = GetInput("Enter new additional information: ");
            UpdateItem(index, newTitle, newAuthor, newPublishYear, newAdditionalInfo);
        }
        private void DeleteItem()
        {
            DisplayAllItemInfo();
            Console.Write("\nEnter the number of the item to delete (or 0 to cancel): ");
            int choice = GetUserChoice();

            if (choice == 0)
            {
                Console.WriteLine("Deletion cancelled.");
                return;
            }

            DeleteItem(choice - 1);
        }
        private void SearchItems()
        {
            string searchTerm = GetInput("\nEnter search term (title or author): ");
            var searchResult = SearchItems(searchTerm);

            if (searchResult.Count == 0)
            {
                Console.WriteLine("No items found matching your search.");
                return;
            }

            Console.WriteLine($"\nFound {searchResult.Count} items:");
            foreach (var libraryItem in searchResult)
            {
                ((LibraryItem)libraryItem).DisplayInfo();
            }
        }
        private string GetAdditionalInformation(ItemType type)
        {
            return type switch
            {
                ItemType.Book => GetInput("Enter genre: "),
                ItemType.Magazine => GetInput("Enter issue number: "),
                ItemType.Article => GetInput("Enter journal name: "),
                _ => ""
            };
        }
        private string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? "";
        }
        private int GetUserChoice()
        {
            return int.TryParse(Console.ReadLine(), out int choice) ? choice : 0;
        }
        private bool ValidateItem(LibraryItem item)
        {
            if (item == null)
            {
                Console.WriteLine("Error: Cannot add null item");
                return false;
            }

            if(string.IsNullOrEmpty(item.Author)) 
            {
                Console.WriteLine("Author cannot be empty!");
                return false;
            }

            if (string.IsNullOrEmpty(item.Title))
            {
                Console.WriteLine("Title cannot be empty!");
                return false;
            }

            if (item.PublishYear <= 0 || item.PublishYear > DateTime.Now.Year)
            {
                Console.WriteLine($"Invalid PublishYear. Publishyear must between 1 or {DateTime.Now.Year}");
            }

            return true;
        }
        private bool ValidateIndex(int index)
        {
            if (index < 0 || index >= _libraryItems.Count)
            {
                Console.WriteLine("Invalid item index");
                return false;
            }

            return true;
        }
        private bool ValidateItemDetails(string title, string author, int publishYear)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("Title and author cannot be empty.");
                return false;
            }

            if (publishYear < 1000 || publishYear > DateTime.Now.Year)
            {
                Console.WriteLine($"Publish year must be between 1000 and {DateTime.Now.Year}.");
                return false;
            }

            return true;
        }
        private bool ValidateAdditionalInfo(string additionalInfo, string errorMessage, out int parsedValue)
        {
            if (!int.TryParse(additionalInfo, out parsedValue))
            {
                Console.WriteLine(errorMessage);
                return false;
            }

            return true;
        }
        private bool ValidateAdditionalInfo(string additionalInfo, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(additionalInfo))
            {
                Console.WriteLine(errorMessage);
                return false;
            }

            return true;
        }
        #endregion
    }
}
