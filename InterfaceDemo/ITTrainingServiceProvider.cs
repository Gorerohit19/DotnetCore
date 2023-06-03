namespace Training;

public class ITTrainingServiceProvider:TrainingInterface
{
    public void Tech()
    {
        Console.WriteLine("Candidate have been taught Computer Science Subjects");
    }

    public void Evaluate()
    {
        Console.WriteLine("Candidate have been evaluated against Computer Science");
    }

    public void ConductingPracticle()
    {
        Console.WriteLine("Conducting java, .net, mysql, react practical");
    }
}