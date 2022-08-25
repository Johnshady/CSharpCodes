using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace PhoneBook.validator
{
    class validatorFNS
    {
        public bool queryFormat(string inputQuery)
        {
            if (phoneNameChecker(inputQuery))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool phoneBookFormat(string inputPhoneRecord)
        {
            string[] inputPhoneRecordSplit = inputPhoneRecord.Split(null);

            if (inputPhoneRecordSplit.Length == 3)
            {
                if (phoneNameChecker(inputPhoneRecordSplit[0]) &&
                    phoneNumberChecker(inputPhoneRecordSplit[inputPhoneRecordSplit.Length - 1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            else
            {
                return false;
            }

        }

        public bool nChecker(string nValue)
        {
            if (isInteger(nValue))
            {
                int nValueInt = Convert.ToInt32(nValue);

                if (nValueInt > 0 && nValueInt < 100001)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            else
            {
                return false;
            }
        }

        public bool phoneNameChecker(string phoneNameString)
        {
            if (Regex.IsMatch(phoneNameString, @"^[a-z]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool phoneNumberChecker(string phoneNumberString)
        {
            if ((isInteger(phoneNumberString)) && (phoneNumberString.Count() == 8))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isInteger(string intInString)
        {
            try
            {
                int newNumber = Convert.ToInt32(intInString);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

    }

}
