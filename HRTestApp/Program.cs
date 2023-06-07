
using  HR;
//Employees.ShowAll();
//Employees.ShowById(); 
//Employees.DeleteEmployeeDetails();
//Employees.UpdateEmployeeDetails();
//Employees.InsertEmployees();

using MySqlOperationLib;
//CrudOperation.ShowAll();
//CrudOperation.ShowById();
// CrudOperation.InsertDepartment();
// CrudOperation.Delete();
//CrudOperation.UpdateDeptHead();

int choice;
do
{
    Console.WriteLine(); Console.WriteLine();
    Console.WriteLine("1.Show All Data");
    Console.WriteLine("2.Show data by input id");
    Console.WriteLine("3.Insert Data");
    Console.WriteLine("4.update Data");
    Console.WriteLine("5.Delete department data");
    Console.WriteLine("0.***Exit***");

    Console.WriteLine();
    Console.WriteLine("Enter Your option");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1: CrudOperation.ShowAll(); break;
        case 2: CrudOperation.ShowById(); break;
        case 3: CrudOperation.InsertDepartment(); break;
        case 4:
            int n;
            do
            {
                Console.WriteLine(); Console.WriteLine();


                Console.WriteLine("1.Update department name");
                Console.WriteLine("2.Update department Manager");
                Console.WriteLine("3.Update department Head");
                Console.WriteLine("4.Update department location");
                Console.WriteLine("5.Update department All data");
                Console.WriteLine("0.***Exit***");
                Console.WriteLine();
                Console.WriteLine("Enter Your option");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1: CrudOperation.UpdateDeptName(); break;
                    case 2: CrudOperation.UpdateDeptmanager(); break;
                    case 3: CrudOperation.UpdateDeptHead(); break;
                    case 4: CrudOperation.UpdateDeptLocation(); break;
                    case 5: CrudOperation.UpdateAll(); break;
                    default: Console.WriteLine("Invalid Input"); break;

                }
            } while (n != 0);

            break;

        case 5: CrudOperation.InsertDepartment(); break;
        case 0: Console.WriteLine("***Exiting***"); break;
        default: Console.WriteLine("Invalid Input"); break;
    }
} while (choice != 0);




