using Training;
using DeviceManagement;
using Accounding;
using System.Collections.Generic;
/*
TrainingInterface transflower = new ITTrainingServiceProvider();

Console.WriteLine("transflower instance method invocation");
transflower.ConductingPracticle();
transflower.Evaluate();
transflower.Tech();

TrainingInterface qSpider = new ITTrainingServiceProvider();

Console.WriteLine("\nQSpider Instance method invocation");
qSpider.ConductingPracticle();
qSpider.Evaluate();
qSpider.Tech();


TrainingInterface awateCollege = new CoreScienceTrainingServiceProvider();

Console.WriteLine("\nAwate College Instance method invocation");
awateCollege.ConductingPracticle();
awateCollege.Evaluate();
awateCollege.Tech();


TrainingInterface rajguruNagarCollege = new CoreScienceTrainingServiceProvider();

Console.WriteLine("\nRajgiriNagar College instance method invocation");
rajguruNagarCollege.ConductingPracticle();
rajguruNagarCollege.Evaluate();
rajguruNagarCollege.Tech();
*/

/*
//This example using collection and interface we are solving 
//College administration problem
//empty list created

//Container
List<TrainingInterface> institutes = new List<TrainingInterface>();

ITTrainingServiceProvider transflower = new ITTrainingServiceProvider();
ITTrainingServiceProvider qSpider = new ITTrainingServiceProvider();

CoreScienceTrainingServiceProvider awateCollege = new CoreScienceTrainingServiceProvider();
CoreScienceTrainingServiceProvider rajguruNagarCollege = new CoreScienceTrainingServiceProvider();

AutoMobileTrainingServiceProvider itiPune = new AutoMobileTrainingServiceProvider();
AutoMobileTrainingServiceProvider itiNarayangoan = new AutoMobileTrainingServiceProvider();


institutes.Add(transflower);
institutes.Add(qSpider);
institutes.Add(awateCollege);
institutes.Add(rajguruNagarCollege);
institutes.Add(itiPune);
institutes.Add(itiNarayangoan);

foreach(TrainingInterface institute in institutes)
{
     Console.WriteLine("\nTraining provider method invocation");
    institute.ConductingPracticle();
    institute.Evaluate();
    institute.Tech();
}
*/

Device robot = new Device();
Console.WriteLine("Robot Device");
robot.Draw();
robot.Print();
robot.Write();
robot.Read();

Transaction bankTransaction = new Transaction();
Console.WriteLine("\nTransaction in Banking");
bankTransaction.Deposite();
bankTransaction.Withdraw();