using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace PhoneBookTextFile
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Hashtable tab = new Hashtable();
//            string fileName;
//            if {
//                (args.Length > 0) fileName = args[0];
//            }
//            else
//            {
//                fileName = "phoneBook.txt";
//            }
//            StreamReader r = File.OpenText(fileName);
//            string line = r.ReadLine();
//            while (line != null)
//            {
//                int pos = line.IndexOf(' ');
//                string name = line.Substring(0, pos).Trim();
//                long phone = Convert.ToInt64(line.Substring(pos + 1));
//                tab[name] = phone;
//                line = r.ReadLine();
//            }
//            r.Close();
//            for (; ; )
//            {
//                Console.Write("Name : ");
//                string name = Console.ReadLine().Trim();
//                if (name == "")
//                    break;
//                object phone = tab[name];
//                if (phone == null)
//                    Console.WriteLine("-- Not found in Phone Book");
//                else
//                    Console.WriteLine(phone);
//            }
//        }
//    }
//}




class WriteAndReadToFile
{

    private readonly string UserTextFile = ConfigurationManager.AppSettings["textFileName"];

    public void WriteUserToFile(Person person)
    {
        using (StreamWriter sw = new StreamWriter(UserTextFile, true))
        {
            sw.WriteLine(person.FirstName + "," + person.LastName + "," + person.Adress + ",");
        }
    }

    public void ReadFromFile(AdressBook ab)
    {
        string textLine;
        try
        {
            using (StreamReader sr = new StreamReader(UserTextFile))
            {
                while ((textLine = sr.ReadLine()) != null)
                {
                    string[] userInformation = textLine.Split(',');
                    Person p = new Person(userInformation[0], userInformation[1], userInformation[2]);
                    ab.AdressBookList.Add(p);
                }
            }
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine("File does not exist " + fnf);
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went wrong" + e);
        }
    }
