using knowledge_check_inheritance;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());


var recordList = new List<charmander>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var stuff = new charmander();

    Console.WriteLine("What kind of attack: ");
    stuff.AttackCanPerform = Console.ReadLine();

    Console.WriteLine("What type is it: ");
    stuff.TypeofAttack = Console.ReadLine();

    recordList.Add(new charmander() { AttackCanPerform = stuff.AttackCanPerform, TypeofAttack = stuff.TypeofAttack });
}
// Print out the list of records using Console.WriteLine()
foreach (var entry in recordList)
    Console.WriteLine("Attack they can perform " + entry.AttackCanPerform + " Type of attack " + entry.TypeofAttack);