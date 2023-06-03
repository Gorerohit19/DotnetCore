namespace Training;

public class CoreScienceTrainingServiceProvider : TrainingInterface
{
    public void Tech()
    {
        Console.WriteLine(" Candidate have been taught physics, Chemistry, Biology Subjects");
    }

    public void Evaluate()
    {
        Console.WriteLine("Candidate have been evaluated against physics, Chemistry, Biology");
    }

    public void ConductingPracticle()
    {
        Console.WriteLine("Conducting physics, Chemistry, Biology practical");
    }
}