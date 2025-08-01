﻿using LMSWithArrayList.Managers;

namespace LMSWithArrayList
{
    internal class Program
    {
        /// <summary>
        /// Main program class for the Library Management System
        /// </summary>
       
            private static AuthenticationManager _authenticationManager;
            private static LibraryManager _libraryManager;

            /// <summary>
            /// Entry point of the application
            /// </summary>
            /// <param name="args">Command line arguments (not used)</param>
            static void Main(string[] args)
            {
                /*
                 * Application Initialization and Flow
                 * ==================================
                 * 
                 * Step 1: System Initialization
                 * - Create authentication manager for user access control
                 * - Create library manager for handling library items
                 * 
                 * Step 2: User Authentication
                 * - Handle login process with retry mechanism
                 * - Validate user credentials
                 * - Provide feedback on authentication status
                 * 
                 * Step 3: Main Application Loop
                 * - Display menu options
                 * - Process user input
                 * - Execute selected operations
                 * - Continue until user chooses to exit
                 */

                InitializeSystem();

                // Attempt user login with proper error handling
                if (!_authenticationManager.Login())
                {
                    Console.WriteLine("Login failed. Exiting program");
                    return;
                }

                // Start the main application menu after successful authentication
                RunMainMenu();
            }

            /// <summary>
            /// Initializes the system managers
            /// </summary>
            private static void InitializeSystem()
            {
                _authenticationManager = new AuthenticationManager();
                _libraryManager = new LibraryManager();
            }

            /// <summary>
            /// Manages the main menu loop of the application
            /// </summary>
            private static void RunMainMenu()
            {
                _libraryManager.RunMainMenu();
            }
        }
    }

