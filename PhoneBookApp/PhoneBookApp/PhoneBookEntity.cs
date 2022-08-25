using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.entity
{
    class entityFNS
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        public bool enterRecord(string phoneBookRecord)
        {
            string[] phoneBookRecordSplit = phoneBookRecord.Split(null);
            try
            {
                phoneBook.Add(phoneBookRecordSplit[0], phoneBookRecordSplit[phoneBookRecordSplit.Length - 1]);
                return true;
            }
            catch (ArgumentException)
            {
                return false;

            }
        }



        public Dictionary<string, string> readAllRecords()
        {
            return phoneBook;
        }



        public bool seachName(string recordInput)
        {
            string[] recordInputSplit = recordInput.Split(null);

            if (phoneBook.ContainsKey(recordInputSplit[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}