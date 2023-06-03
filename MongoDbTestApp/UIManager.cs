namespace MongoDbTest;

public class UIManager
{
    public static List<Student> GetallStudent()
    {
        List<Student> students = StudentDBManager.GetAllStudent();
        return students;
    }
}