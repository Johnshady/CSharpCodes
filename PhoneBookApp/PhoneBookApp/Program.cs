using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.validator;
using PhoneBook.output;
using PhoneBook.entity;


namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int nValueHolder = 0;
            int inputPhoneRecordCounter = 0;
            List<string> queriesHolder = new List<string>();

            validatorFNS oValidator = new validatorFNS();
            entity.entityFNS oEntity = new entity.entityFNS();
            outputFNS oOutput = new outputFNS();

            Console.Write(oOutput.welcomeMessage());
            Console.Write(oOutput.nGuidelines());
            Console.Write(oOutput.phoneBookGuidelines());
            Console.Write(oOutput.queryGuidelines());
            Console.Write(oOutput.exitQueryGuidelines());
            Console.WriteLine("\n\n");


            while (true)
            {
                string nValueStr = Console.ReadLine();

                if (oValidator.nChecker(nValueStr))
                {
                    nValueHolder = Convert.ToInt32(nValueStr);
                    break;
                }
                else
                {
                    Console.Write(oOutput.nGuidelines());
                }
            }

            while (true)
            {
                if (inputPhoneRecordCounter == nValueHolder)
                {
                    break;
                }
                else
                {
                    string phoneRecordStr = Console.ReadLine();
                    if (oValidator.phoneBookFormat(phoneRecordStr) && !oEntity.seachName(phoneRecordStr))
                    {
                        oEntity.enterRecord(phoneRecordStr);

                        inputPhoneRecordCounter++;
                    }
                    else
                    {
                        Console.Write(oOutput.phoneBookGuidelines());

                    }
                }


            }

            while (true)
            {
                string queryNameHolder = Console.ReadLine();

                if (oValidator.isInteger(queryNameHolder) && queriesHolder.Count > 0)
                {
                    break;
                }
                else
                {
                    if (oValidator.queryFormat(queryNameHolder))
                    {
                        queriesHolder.Add(queryNameHolder);
                    }
                    else
                    {
                        Console.Write(oOutput.queryGuidelines());
                    }
                }

            }

            Console.WriteLine(oOutput.readQueryRecords(queriesHolder, oEntity.readAllRecords()));

            Console.ReadKey();

        }
    }
}
