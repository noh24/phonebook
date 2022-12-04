using System;
using System.Collections.Generic;

class PhoneBook
{
  public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

  static void Main()
  {
    Console.WriteLine("Main Menu");
    Console.WriteLine("Do you want to add contacts? [Enter Y for yes or N for no.]");
    string addContactAnswer = Console.ReadLine();
    if (addContactAnswer == "Y" || addContactAnswer == "y")
    {
      AddContact();
    }
    else
    {
      Console.WriteLine("Do you want to look up contacts? [Enter Y for yes or N for no.]");
      string lookUpContactAnswer = Console.ReadLine();
      if (lookUpContactAnswer == "Y" || lookUpContactAnswer == "y")
      {
        LookUpContact();
      }
      else
      {
        Console.WriteLine("Do you want to exit the program? [Enter Y for yes or N for no.]");
        string exitProgramAnswer = Console.ReadLine();
        if (exitProgramAnswer == "Y" || exitProgramAnswer == "y")
        {
          Console.WriteLine("Thank for using our services.");
        }
        else
        {
          Main();
        }
      }
    }
  }
  static void AddContact()
  {
    Console.WriteLine("Add Contact");
    Console.WriteLine("Enter a new contact name.");
    string contactFirstName = Console.ReadLine();
    Console.WriteLine("Enter a new contact phone number.");
    string contactPhoneNumber = Console.ReadLine();
    if (phoneNumbers.ContainsKey(contactFirstName))
    {
      Console.WriteLine("This person is already a contact in your phonebook.");
      Console.WriteLine(contactFirstName + "\'s phone number is " + phoneNumbers[contactFirstName]);
    }
    else
    {
      phoneNumbers.Add(contactFirstName, contactPhoneNumber);
      Console.WriteLine("Contact has been successfully added.");
    }
    Main();
  }
  static void LookUpContact()
  {
    Console.WriteLine("Find Contact");
    Console.WriteLine("Enter contact first name.");
    string contactFirstName = Console.ReadLine();
    if (phoneNumbers.ContainsKey(contactFirstName))
    {
      Console.WriteLine(contactFirstName + "\'s phone number is " + phoneNumbers[contactFirstName]);
    }
    else
    {
      Console.WriteLine(contactFirstName + " is not an existing contact. Would you like to add? [Enter Y for yes or N for no]");
      string addContactAnswer = Console.ReadLine();
      if (addContactAnswer == "Y" || addContactAnswer == "y")
      {
        AddContact();
      }
    }
    Main();
  }
}

// Main() handles user interactivity
// AddContact() handles adding contact into Dictionary object
// LookUp() handles looking up contact and displaying information