using DisconnectedTest;
/* Check
//Get All Departmet Method
List<Department> allDepartments = DeparmentDBManger.GetAllDepartment();
foreach(Department department in allDepartments)
{
    Console.WriteLine(department.Id+" "+ department.Name +" "+ department.Location);
}
*/

/*
 //Get Department By Id Method : Check
Console.WriteLine("Enter Department id Which you want to see");
int id = int.Parse(Console.ReadLine());
Department dept = DeparmentDBManger.GetDepartmetById(id);
Console.WriteLine(dept.Id + "--" + dept.Name +"--"+ dept.Location);
*/


//Get Department By Location Method
Console.WriteLine("Enter Loaction of Department which u want to see");
string location = Console.ReadLine();
List<Department> allDepartments = DeparmentDBManger.GetByLocation(location);
foreach(Department theDepartment in allDepartments)
{
    Console.WriteLine(theDepartment.Id +" "+ theDepartment.Name);
}

/*
//Get By Departmet Id method
Console.WriteLine("Enter Department id which u want to show");
int id = int.Parse(Console.ReadLine());
Department dept = DeparmentDBManger.GetDepartmetById(id);
Console.WriteLine(dept.Id +" "+ dept.Name +" "+ dept.Location);
*/
/*
//Inserting New Department 
Department department = new Department();
department.Name = "Accounting";
department.Location = "Satara";
bool status = DeparmentDBManger.Insert(department);
*/

/*
//UpDating Exsist Department

Department department = new Department();
Console.WriteLine("Enter Department Id to be Updated");
department.Id = int.Parse(Console.ReadLine());
if(DeparmentDBManger.GetByDepartmentId(department.Id))
{

}
*/

/*
// Deletion Method
bool status = DeparmentDBManger.Delete(5);
*/
