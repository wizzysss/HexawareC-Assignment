using SISwithDB.Repositories;
using SISwithDB.Models;
using System.Xml.Serialization;
using System.Transactions;
using SISwithDB.Exceptions;
using SISwithDB.StudentManagementApp;

namespace Student_Info_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudManagementSys menu = new StudManagementSys();
            menu.MainMenu();
        }
    }
}
