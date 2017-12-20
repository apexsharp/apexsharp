namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    public class Demo
    {
        public Contact contact { get; set; }

        public Demo()
        {
            contact = new Contact();
        }

        public PageReference save()
        {
            try
            {
                Soql.insert(contact);
            }
            catch (DmlException e)
            {
                // ToDo
                // ApexPages.addMessages(e);
            }

            return null;
        }

        public static string updatePhone(string email, string newPhone)
        {
            List<Contact> contacts = getContactByEMail(email);
            if (contacts.isEmpty())
            {
                return "Not Found";
            }
            else
            {
                contacts[0].Phone = newPhone;
                updateContacts(contacts);
                return "Phone Number Updated";
            }
        }

        public static List<Contact> getContactByEMail(string email)
        {
            List<Contact> contacts = Soql.query<Contact>("SELECT Id, Email, Phone FROM Contact WHERE Email = :email", email);
            return contacts;
        }

        public static List<Contact> getContacts()
        {
            List<Contact> contacts = Soql.query<Contact>("SELECT Id, Email, Phone FROM Contact");
            return contacts;
        }

        public static void updateContacts(List<Contact> contacts)
        {
            Soql.update(contacts);
        }
    }
}
