using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookManagementSystem.Enums
{
    public enum MenuOption
    {
        /// <summary>
        /// Option to add a new contact to the phone book.
        /// Corresponds to menu choice 1.
        /// </summary>
        AddContact = 1,


        /// <summary>
        /// Option to update an existing contact's information.
        /// Corresponds to menu choice 2.
        /// </summary>
        UpdateContact = 2,


        /// <summary>
        /// Option to search for a contact by name.
        /// Corresponds to menu choice 3.
        /// </summary>
        SearchContact = 3,


        /// <summary>
        /// Option to view all contacts in alphabetical order.
        /// Corresponds to menu choice 4.
        /// </summary>
        ViewAllContacts = 4,


        /// <summary>
        /// Option to delete a contact from the phone book.
        /// Corresponds to menu choice 5.
        /// </summary>
        DeleteContact = 5,


        /// <summary>
        /// Option to save all changes and exit the application.
        /// Corresponds to menu choice 6.
        /// </summary>
        SaveAndExit = 6 
    }
}
