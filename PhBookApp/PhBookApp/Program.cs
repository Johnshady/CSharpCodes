//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.IO; //added
//using System.Windows.Forms;
//using System.Runtime.Serialization.Formatters.Binary; //added
//using System.Runtime.Serialization; //added

//namespace PhBookApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}
////Here is a full code of our application with comments after "//"cases:

//namespace testowa // this my name of project
//{

//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        [Serializable] // It allow our class to be saved in file
//        public class data // Our class for data
//        {
//            public string name;
//            public string surname;
//            public string city;
//            public string number;

//        }

//        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            GRID.EndEdit();
//            SaveFileDialog saveFileDialog1 = new SaveFileDialog(); //Creating a file save dialog

//            saveFileDialog1.RestoreDirectory = true;
//            //read and filter the raw data
//            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
//            {
//                BinaryFormatter formatter = new BinaryFormatter();
//                FileStream output = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
//                '
//            int n = GRID.RowCount;
//                data[] Person = new data[n - 1]; //We have as many records as many rows, rows are added automaticly so we have always one row more than we need, so n is a number of rows -1 empty row
//                for (int i = 0; i < n - 1; i++)
//                {

//                    Person[i] = new data();
//                    //GRID has two numbers in"[]" first numer is an index of column, second is a an idnex of row', indexing always starts from 0'
//                    Person[i].name = GRID[0, i].Value.ToString();
//                    Person[i].surname = GRID[1, i].Value.ToString();
//                    Person[i].city = GRID[2, i].Value.ToString();
//                    Person[i].number = GRID[3, i].Value.ToString();

//                }

//                formatter.Serialize(output, Person);

//                output.Close();
//            }

//        }

//        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) // Reading a File and adding data to GRID
//        {
//            openFileDialog1 = new OpenFileDialog();
//            if (openFileDialog1.ShowDialog() == DialogResult.OK)
//            {
//                BinaryFormatter reader = new BinaryFormatter();
//                FileStream input = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
//                data[] Person = (data[])reader.Deserialize(input);
//                GRID.Rows.Clear();
//                for (int i = 0; i < Person.Length; i++)
//                {
//                    GRID.Rows.Add();
//                    GRID[0, i].Value = Person[i].name;
//                    GRID[1, i].Value = Person[i].surname;
//                    GRID[2, i].Value = Person[i].city;
//                    GRID[3, i].Value = Person[i].number;

//                }

//            }
//        }

//        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            Close(); // closing an app
//        }
//    }
//}




//class Program
//{
//    static ArrayList tel_book_arr = new ArrayList();
//    static void Main(string[] args)
//    {

//        int sel = 0;

//        while (sel != 6)
//        {
//            Console.Clear();
//            Console.WriteLine("1 : enter information");
//            Console.WriteLine("2 : display information");
//            Console.WriteLine("3 : search information");
//            Console.WriteLine("4 : edit information");
//            Console.WriteLine("5 : delete information");
//            Console.WriteLine("6 : exit");

//            Console.Write("\nenter your choose : ");
//            sel = Convert.ToInt32(Console.ReadLine());

//            switch (sel)
//            {
//                case 1:
//                    enter_info();
//                    break;
//                case 2:
//                    show_info();
//                    break;
//                case 3:
//                    search_ifo();
//                    break;
//                case 4:
//                    edit_info();
//                    break;
//                case 5:
//                    delet_ifo();
//                    break;
//            }
//        }

//    }

//    static void enter_info()
//    {
//        Console.Clear();

//        telephone t = new telephone();

//        Console.Write("enter name : ");
//        t.name = Console.ReadLine();

//        Console.Write("enter family : ");
//        t.family = Console.ReadLine();

//        Console.Write("enter tel : ");
//        t.tel = Console.ReadLine();

//        tel_book_arr.Add(t);
//    }

//    static void show_info()
//    {
//        Console.Clear();

//        foreach (telephone temp in tel_book_arr)
//        {
//            Console.WriteLine("name : " + temp.name);
//            Console.WriteLine("family : " + temp.family);
//            Console.WriteLine("tel : " + temp.tel);
//            Console.ReadKey();
//        }
//    }

//    static void search_ifo()
//    {
//        Console.Clear();
//        object name = Console.Read("please enter the number: ");
//        object family = Console.Read("please enter the family: ");
//    }
//    static void edit_info()
//    {
//        Console.Clear();
//        search_ifo();
//    }
//    static void delet_ifo()
//    {
//        Console.Clear();
//    }
//}

//class telephone
//{
//    public string name, family, tel;
//}

////Example  of using a list instead of arraylist
//Dictionary<string, string> phonebook = new Dictionary<string, string>();
//phonebook.Add("Fred", "555-5555");
//phonebook.Add("Harry", "555-5556");

//// See if Dictionary contains this string
//if (phonebook.ContainsKey("Fred")) // True
//{
//    string number = phonebook["Fred"];
//    Console.WriteLine(number);
//}

//// See if Dictionary contains this string
//if (phonebook.ContainsKey("Jim"))
//{
//    Console.WriteLine("Not in phonebook"); // Nope




//GITHUB REPOSITORY

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
//Footer




//https://github.com/zedecliff/PhoneBook/find/master





//Validator class

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

namespace PhoneBook.validator
{
    /*========================================================================================
    * THIS IS THE VALIDATOR CLASS, it is in charge of validating user input.
    *  1. Query Format
    *  2. phonebook format
    *  3. n validity
    *  4. phone number validity.
    *  5. phone name validity
    *  
    *  N/B
    *  => this program will use (interger) data type because no input or number will
    *      go beyound  {2,147,483,647}
     ========================================================================================*/
    class validatorFNS
    {

        /*===================================================================================
        *  query format => {name(string)}
        *  
        *  RULES     : only one name is used, if 2 names the format is wrong
        *              only english letters no digits (english names)
        *              onlu lowercase, uppercase will be rejected
         ===================================================================================*/
        public bool queryFormat(string inputQuery)
        {
            /*check if the name is valid*/
            if (phoneNameChecker(inputQuery))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /*===================================================================================
         *  phone book format => {name(string) (2 spaces) phoneNumber(8 digits)}
         *  space == null, new char[0]
         *===================================================================================*/
        public bool phoneBookFormat(string inputPhoneRecord)
        {
            /*confirm if phone number and name are separated by 2 spaces*/
            string[] inputPhoneRecordSplit = inputPhoneRecord.Split(null);

            if (inputPhoneRecordSplit.Length == 3)
            {
                /*check if the name and number is valid*/
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



        /*===================================================================================
         *  n Value => 1 <= x <= 100,000
         *  n must be an integer, no string
         ===================================================================================*/
        public bool nChecker(string nValue)
        {
            /*check if n value is an integer*/
            if (isInteger(nValue))
            {
                /*check for 1 <= n <= 100,000*/
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



        /*===================================================================================
        *  Phone name MUST be english words only
        *  only characters(letters), lowercase only uppercase will be rejected
        * 
       ===================================================================================*/
        public bool phoneNameChecker(string phoneNameString)
        {
            /*first check if its only letters*/
            if (Regex.IsMatch(phoneNameString, @"^[a-z]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        /*===================================================================================
         *  Phone number MUST be 8 digits
         *    => {18928909}, only digits
         * 
        ===================================================================================*/
        public bool phoneNumberChecker(string phoneNumberString)
        {
            /*first check if its an integer and it it has 8 digits*/
            if ((isInteger(phoneNumberString)) && (phoneNumberString.Count() == 8))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /*===================================================================================
        *  Checks if a given string is an integer
        * 
       ===================================================================================*/
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