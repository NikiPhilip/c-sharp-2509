
//Create a class Configuration to load system-wide settings (e.g., application 
//name) using a static constructor.Allow individual users to set preferences using an instance
//constructor.

using System;

namespace Assignment14
{
    public class Configuration
    {
        public static string ApplicationName;
        public string UserPreference;

        static Configuration()
        {
            ApplicationName = "My Application";
            Console.WriteLine("Static constructor called.System wide settings loaded");

        }
        public Configuration(string userPreference)
        {
            this.UserPreference = userPreference;
            Console.WriteLine($"Instance constructor called. User preference set to: {UserPreference}");
        }

        // Method to display current settings
        public void DisplaySettings()
        {
            Console.WriteLine($"Application Name: {ApplicationName}");
            Console.WriteLine($"User Preferences: {UserPreference}");
        }
    }
}