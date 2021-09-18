
using System;
using System.Data;
using System.Data.SqlClient;
using Modell;
using DataAccessLayerr;

namespace TAProject
{
    public class TrainingAcademy
    {
        static void Main(string[] args)
        {


            Console.WriteLine("***********************************************************");
            Console.WriteLine("=================== ACADEMY DETAILS ========================");
            Console.WriteLine("************************************************************");
            DAL D = new DAL();


            D.DisplayStudent();
            Student s1 = D.GetInputFromUser();
            D.AddStudent(s1);
            D.DisplayStudent();
            Student s2 = D.GetInputFromUser();
            D.EditStudent(s2);
            D.DisplayStudent();

            D.DeleteStudent();
            D.DisplayStudent();
            D.ShowBestStudent();

        }
    }
}

