using System;
using System.Data.SqlClient;

internal class Program
{
    public static void Main(string[] args)
    {
        SqlConnection sqlconnection;
        String CONNECTION = "server=DESKTOP-2GMEK14\\SQLEXPRESS01;initial catalog=payroll;integrated security=SSPI";
        try
        {
            sqlconnection = new SqlConnection(CONNECTION);    
            sqlconnection.Open();
            Console.WriteLine("connection established sucesfully !");
            Console.WriteLine("enter your choice \n1.insert\n2.update\n3.delete\n4.display");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            { 

              // query to insert a data in to a table
              case 1:
                {
                    Console.WriteLine("enter your name :");
                    string userName = Console.ReadLine();
                    Console.WriteLine("enter your age");
                    int userAge = int.Parse(Console.ReadLine());
                    string insertQuery = "INSERT INTO employees_pay(emp_name,emp_age)VALUES('" + userName + "'," + userAge + ")";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, sqlconnection);
                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("data is added sucesfully !");
                    break;
                }
               //  for update the data
              case 2:
                {
                    Console.WriteLine("enter the AGE we need  to update  : ");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the update age :");
                    int up_age = int.Parse(Console.ReadLine());
                    string updataQuery = "UPDATE  employees_pay SET emp_age = " + up_age + " WHERE emp_age = " + age + " ";
                    SqlCommand updataCommand = new SqlCommand(updataQuery, sqlconnection);
                    updataCommand.ExecuteNonQuery();
                    Console.WriteLine("updataed sucesfully");
                    break;
                }
                 // for delete
              case 3:
                {
                    Console.WriteLine("enter the data to delete");
                    string name = Console.ReadLine();
                    string deleteQuery = "DELETE FROM employees_pay  WHERE emp_name = " + name + "";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlconnection);
                    deleteCommand.ExecuteNonQuery();
                    Console.WriteLine("deleted sucesfully !");
                    break;
                }
                // for sellect command
              case 4:
                {
                    string displayQuery = "select * from employees_pay";
                    SqlCommand displayCommand = new SqlCommand(displayQuery, sqlconnection);
                    SqlDataReader reader = displayCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("ID :" + reader.GetValue(0).ToString());
                        Console.WriteLine("NAME :" + reader.GetValue(1).ToString());
                        Console.WriteLine("AGE :" + reader.GetValue(2).ToString());
                    }
                    reader.Close();
                    break;
                }
                default:
                {
                    Console.WriteLine("enterted choice is not correct");
                    break;
                }

             }
                
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}