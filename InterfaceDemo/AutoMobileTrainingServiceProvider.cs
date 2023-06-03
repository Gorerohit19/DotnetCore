namespace Training;

public class AutoMobileTrainingServiceProvider : TrainingInterface
{
    public void Tech()
    {
        Console.WriteLine("Candidate have been taught SOM, TOM, Dynamics Subjects");
    }

    public void Evaluate()
    {
        Console.WriteLine("Candidate have been evaluated against Elements of Mechanical Engg.");
    }

    public void ConductingPracticle()
    {
        Console.WriteLine("Conducting two strok, four strok engine practicals");
    }
}