//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PhoneBook
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PhoneBook.output;
using PhoneBook.validator;

namespace PhoneBook
{
    class Program
    {
        /*========================================================================================
         * THIS IS THE MAIN FUNCTION. 
         *  => gets the user input -> validator -> (results(entity) | error) -> output
         *========================================================================================*/
        static void Main(string[] args)
        {
            /*variable declaration and initializations*/
            int nValueHolder = 0;
            int inputPhoneRecordCounter = 0;
            List<string> queriesHolder = new List<string>();

            validatorFNS oValidator = new validatorFNS();
            entity.entityFNS oEntity = new entity.entityFNS();
            outputFNS oOutput = new outputFNS();

            /*===================================================================================
             *  WELCOMING MESSAGE
              ===================================================================================*/
            Console.Write(oOutput.welcomeMessage());


            /*===================================================================================
             *  Guideline on how to use the program
              ===================================================================================*/
            Console.Write(oOutput.nGuidelines());
            Console.Write(oOutput.phoneBookGuidelines());
            Console.Write(oOutput.queryGuidelines());
            Console.Write(oOutput.exitQueryGuidelines());
            Console.WriteLine("\n\n");


            /*===================================================================================
             *  get n
              ===================================================================================*/
            while (true)
            {
                string nValueStr = Console.ReadLine();

                /*check if n is valid*/
                if (oValidator.nChecker(nValueStr))
                {
                    nValueHolder = Convert.ToInt32(nValueStr);
                    break;
                }
                else
                {
                    /*show guidelines*/
                    Console.Write(oOutput.nGuidelines());
                }
            }



            /*===================================================================================
             *  get the phone records
             *  => read n number of phone records
             ===================================================================================*/

            while (true)
            {
                if (inputPhoneRecordCounter == nValueHolder)
                {
                    break;
                }
                else
                {
                    /*read phone record if format is wrong prompt to enter valid record*/
                    string phoneRecordStr = Console.ReadLine();
                    if (oValidator.phoneBookFormat(phoneRecordStr) && !oEntity.seachName(phoneRecordStr))
                    {
                        /*format is OK, save the data*/
                        oEntity.enterRecord(phoneRecordStr);

                        inputPhoneRecordCounter++;
                    }
                    else
                    {
                        /*display guidelines*/
                        Console.Write(oOutput.phoneBookGuidelines());

                    }
                }


            }



            /*===================================================================================
            *  get the queries
            *  => read 1 >= queries <= 100,000
            *  exit by entering any integer value
            ===================================================================================*/
            while (true)
            {
                /*read the name*/
                string queryNameHolder = Console.ReadLine();

                /*check if its exit*/
                if (oValidator.isInteger(queryNameHolder) && queriesHolder.Count > 0)
                {
                    /*exit and display output*/
                    break;
                }
                else
                {
                    if (oValidator.queryFormat(queryNameHolder))
                    {
                        /*save the query*/
                        queriesHolder.Add(queryNameHolder);
                    }
                    else
                    {
                        /*show query guidelines*/
                        Console.Write(oOutput.queryGuidelines());
                    }
                }

            }



            /*===================================================================================
             *  PRINT THE OUTPUT.
              ===================================================================================*/
            Console.WriteLine(oOutput.readQueryRecords(queriesHolder, oEntity.readAllRecords()));



            Console.ReadKey();


            /*===================================================================================
           *  END  END  END END
            ===================================================================================*/



        }
    }
}





//Phonebook Entity

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PhoneBook.entity
//{
//    /*========================================================================================
//    * THIS IS THE DATA CLASS, it holds and manipulates the phone book data.
//     ========================================================================================*/
//    class entityFNS
//    {
//        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

//        public bool enterRecord(string phoneBookRecord)
//        {
//            /*get name and number*/
//            string[] phoneBookRecordSplit = phoneBookRecord.Split(null);
//            try
//            {
//                phoneBook.Add(phoneBookRecordSplit[0], phoneBookRecordSplit[phoneBookRecordSplit.Length - 1]);
//                return true;
//            }
//            catch (ArgumentException)
//            {
//                /*that key exists*/
//                return false;

//            }
//        }



//        /*read all records*/
//        public Dictionary<string, string> readAllRecords()
//        {
//            return phoneBook;
//        }



//        /*check if the queried name is present*/
//        public bool seachName(string recordInput)
//        {
//            /*get name and number*/
//            string[] recordInputSplit = recordInput.Split(null);

//            if (phoneBook.ContainsKey(recordInputSplit[0]))
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//    }
//}




// PhoneBookOutput


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PhoneBook.output
//{
//    /*========================================================================================
//     * THIS IS THE OUTPUT CLASS, it is in charge of displaying output in a good format.
//     *  1. Error outputs
//     *  2. phonebook records
//     *  3. guide on how to enter records
//     *  4. Welcoming message, closing messages etc.
//      ========================================================================================*/
//    class outputFNS
//    {
//        public string welcomeMessage()
//        {
//            string welcomeMSG = null;
//            StringBuilder sb = new StringBuilder();

//            string part1 = "===========================================================\n";
//            string part2 = "           PHONE BOOK CONSOLE APPLICATION                  \n";
//            string part3 = "\n\n";

//            sb.Append(part1);
//            sb.Append(part2);
//            sb.Append(part1);
//            sb.Append(part3);

//            welcomeMSG = sb.ToString();

//            return welcomeMSG;
//        }

//        public string nGuidelines()
//        {
//            string nGuidelineFinal = null;
//            StringBuilder sb = new StringBuilder();

//            string part1 = "\nN must be an integer and 1 <= n <= 100,000";
//            string part2 = "\n\n";

//            sb.Append(part1);
//            sb.Append(part2);

//            nGuidelineFinal = sb.ToString();

//            return nGuidelineFinal;
//        }



//        public string phoneBookGuidelines()
//        {
//            string pbGuideFinal = null;
//            StringBuilder sb = new StringBuilder();

//            string part1 = "\nphone record format: (name)(space)(space)(number)\n";
//            string part2 = "name=>(english word), number=>(8 digits), name is unique";
//            string part3 = "\n\n";

//            sb.Append(part1);
//            sb.Append(part2);
//            sb.Append(part3);

//            pbGuideFinal = sb.ToString();

//            return pbGuideFinal;

//        }


//        public string exitQueryGuidelines()
//        {
//            string exitQueryFinal = null;
//            StringBuilder sb = new StringBuilder();

//            string part1 = "\nWhile entering queries(names), enter any number to exit\n1 >= queries <= 100,000\n";
//            string part3 = "\n";

//            sb.Append(part1);
//            sb.Append(part3);

//            exitQueryFinal = sb.ToString();

//            return exitQueryFinal;

//        }


//        public string queryGuidelines()
//        {
//            string queryGudeFinal = null;

//            StringBuilder sb = new StringBuilder();

//            string part1 = "\nquery format: (name)\n";
//            string part2 = "name=>(english word)";
//            string part3 = "\n\n";

//            sb.Append(part1);
//            sb.Append(part2);
//            sb.Append(part3);

//            queryGudeFinal = sb.ToString();

//            return queryGudeFinal;

//        }

//        public string readQueryRecords(List<string> queries, Dictionary<string, string> phoneBook)
//        {
//            entity.entityFNS oEntity = new entity.entityFNS();
//            string outputFinal = null;
//            StringBuilder sb = new StringBuilder();

//            sb.Append("\n\n");

//            for (int i = 0; i < queries.Count; i++)
//            {
//                /*check if key exists*/
//                if (phoneBook.ContainsKey(queries[i]))
//                {
//                    string name = queries[i];
//                    string separator = "=";
//                    string phoneNumber = phoneBook[queries[i]];
//                    string nwLine = "\n";

//                    sb.Append(name);
//                    sb.Append(separator);
//                    sb.Append(phoneNumber);
//                    sb.Append(nwLine);
//                }
//                else
//                {
//                    sb.Append("Not found\n");
//                }
//            }


//            outputFinal = sb.ToString();
//            return outputFinal;

//        }

//    }
//}






//New phonebookApp


#include<stdio.h>

#include<conio.h>

#include<string.h>

#include<process.h>

#include<stdlib.h>

#include<dos.h>

struct contact

{

    long ph;

    char name[20], add[20], email[30];

}
list;

char query[20], name[20];

FILE* fp, *ft;

int i, n, ch, l, found;

int main()

{

main:

    system("cls");    /* ************Main menu ***********************  */

    printf("\n\t **** Welcome to Contact Management System ****");

    printf("\n\n\n\t\t\tMAIN MENU\n\t\t=====================\n\t\t[1] Add a new Contact\n\t\t[2] List all Contacts\n\t\t[3] Search for contact\n\t\t[4] Edit a Contact\n\t\t[5] Delete a Contact\n\t\t[0] Exit\n\t\t=================\n\t\t");

    printf("Enter the choice:");

    scanf("%d", &ch);

    switch (ch)

    {

        case 0:

            printf("\n\n\t\tAre you sure you want to exit?");

            break;

        /* *********************Add new contacts************  */

        case 1:

            system("cls");

            fp = fopen("contact.dll", "a");

            for (; ; )

            {
                fflush(stdin);

                printf("To exit enter blank space in the name input\nName (Use identical):");

                scanf("%[^\n]", &list.name);

                if (stricmp(list.name, "") == 0 || stricmp(list.name, " ") == 0)

                    break;

                fflush(stdin);

                printf("Phone:");

                scanf("%ld", &list.ph);

                fflush(stdin);

                printf("address:");

                scanf("%[^\n]", &list.add);

                fflush(stdin);

                printf("email address:");

                gets(list.email);

                printf("\n");

                fwrite(&list, sizeof(list), 1, fp);

            }

            fclose(fp);

            break;

        /* *********************list of contacts*************************  */

        case 2:

            system("cls");

            printf("\n\t\t================================\n\t\t\tLIST OF CONTACTS\n\t\t================================\n\nName\t\tPhone No\t    Address\t\tE-mail ad.\n=================================================================\n\n");

            for (i = 97; i <= 122; i = i + 1)

            {

                fp = fopen("contact.dll", "r");

                fflush(stdin);

                found = 0;

                while (fread(&list, sizeof(list), 1, fp) == 1)

                {

                    if (list.name[0] == i || list.name[0] == i - 32)

                    {

                        printf("\nName\t: %s\nPhone\t: %ld\nAddress\t: %s\nEmail\t: %s\n", list.name,

                               list.ph, list.add, list.email);

                        found++;

                    }

                }

                if (found != 0)

                {
                    printf("=========================================================== [%c]-(%d)\n\n", i - 32, found);

                    getch();
                }

                fclose(fp);

            }

            break;

        /* *******************search contacts**********************  */

        case 3:

            system("cls");

            do

            {

                found = 0;

                printf("\n\n\t..::CONTACT SEARCH\n\t===========================\n\t..::Name of contact to search: ");

                fflush(stdin);

                scanf("%[^\n]", &query);

                l = strlen(query);

                fp = fopen("contact.dll", "r");

                system("cls");

                printf("\n\n..::Search result for '%s' \n===================================================\n", query);

                while (fread(&list, sizeof(list), 1, fp) == 1)

                {

                    for (i = 0; i <= l; i++)

                        name[i] = list.name[i];

                    name[l] = '\0';

                    if (stricmp(name, query) == 0)

                    {

                        printf("\n..::Name\t: %s\n..::Phone\t: %ld\n..::Address\t: %s\n..::Email\t: %s\n", list.name, list.ph, list.add, list.email);

                        found++;

                        if (found % 4 == 0)

                        {

                            printf("..::Press any key to continue...");

                            getch();

                        }

                    }

                }

                if (found == 0)

                    printf("\n..::No match found!");

                else

                    printf("\n..::%d match(s) found!", found);

                fclose(fp);

                printf("\n ..::Try again?\n\n\t[1] Yes\t\t[0] No\n\t");

                scanf("%d", &ch);

            }
            while (ch == 1);

            break;

        /* *********************edit contacts************************/

        case 4:

            system("cls");

            fp = fopen("contact.dll", "r");

            ft = fopen("temp.dat", "w");

            fflush(stdin);

            printf("..::Edit contact\n===============================\n\n\t..::Enter the name of contact to edit:");

            scanf("%[^\n]", name);

            while (fread(&list, sizeof(list), 1, fp) == 1)

            {

                if (stricmp(name, list.name) != 0)

                    fwrite(&list, sizeof(list), 1, ft);

            }

            fflush(stdin);

            printf("\n\n..::Editing '%s'\n\n", name);

            printf("..::Name(Use identical):");

            scanf("%[^\n]", &list.name);

            fflush(stdin);

            printf("..::Phone:");

            scanf("%ld", &list.ph);

            fflush(stdin);

            printf("..::address:");

            scanf("%[^\n]", &list.add);

            fflush(stdin);

            printf("..::email address:");

            gets(list.email);

            printf("\n");

            fwrite(&list, sizeof(list), 1, ft);

            fclose(fp);

            fclose(ft);

            remove("contact.dll");

            rename("temp.dat", "contact.dll");

            break;

        /* ********************delete contacts**********************/

        case 5:

            system("cls");

            fflush(stdin);

            printf("\n\n\t..::DELETE A CONTACT\n\t==========================\n\t..::Enter the name of contact to delete:");

            scanf("%[^\n]", &name);

            fp = fopen("contact.dll", "r");

            ft = fopen("temp.dat", "w");

            while (fread(&list, sizeof(list), 1, fp) != 0)

                if (stricmp(name, list.name) != 0)

                    fwrite(&list, sizeof(list), 1, ft);

            fclose(fp);

            fclose(ft);

            remove("contact.dll");

            rename("temp.dat", "contact.dll");

            break;

        default:

            printf("Invalid choice");

            break;

    }

    printf("\n\n\n..::Enter the Choice:\n\n\t[1] Main Menu\t\t[0] Exit\n");

    scanf("%d", &ch);

    switch (ch)

    {

        case 1:

            goto main;

        case 0:

            break;

        default:

            printf("Invalid choice");

            break;

    }

    return 0;

}
