
namespace PhoneBookSystem.Constants
{
    public static class AppConstants
    {
        public static Stream FilePath { get; set; }

        public static class Messages
        {
            /*=== Phone Book Management System ===
            1. Add new contact
            2. Update contact
            3. Search contact by name
            4. View all contacts
            5. Delete contact
            6. Save and exit
            Enter your choice:*/
            //Menu Options

            public const string MenuAdd = "1. Add new contact";
            public const string MenuUpdate = "2. Update contact";
            public const string MenuSearch = "3. Search contact by name";
            public const string MenuViewAll = "4. View all contacts";
            public const string MenuDelete = "5. Delete contact";
            public const string MenuSaveAndExit = "6. Save and exit";


            //User input prompts
            public const string PromptName = "Enter name: ";
            public const string PromtPhoneNumber = "Enter phone number: ";
            public const string PromptEmail = "Enter email: ";
            public const string PromptAdress = "Enter adress: ";



            public const string ContactAdded = "Contact added.";
            public const string ContactExists = "A contact with that name already exists.";
            public const string ContactUpdated = "Contact updated.";
            public const string ContactNotFound = "Contact not found.";
            public const string ContactDeleted = "Contact deleted.";
            public const string InvalidEmail = "Invalid email format.";
            public const string InvalidPhone = "Invalid phone number.";
            public const string Saved = "Changes saved. Exiting...";
        }

        public static class FilePaths
        {
            public const string PhoneBookFilePaths = "phonebook.txt";
        }
    }

}
