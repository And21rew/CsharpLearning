using System.Collections.Generic;

namespace Task_2_UsefulAcquaintances
{
    internal class Program
    {
        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();

            foreach (var contact in contacts)
            {
                var searchName = contact.Substring(0, 2).Replace(":", "");

                if (!dictionary.ContainsKey(searchName))
                    dictionary[searchName] = new List<string>();
                dictionary[searchName].Add(contact);
            }

            return dictionary;
        }
    }
}
