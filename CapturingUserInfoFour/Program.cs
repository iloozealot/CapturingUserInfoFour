

//Console application?
//Ask user for first name?
//Welcome Tim as Professor?
//Welcome anyone else as student?
//Ask for name until they give name or type exit?

string? firstName = null;

Console.WriteLine("Welcome to the application: CapturingUserInfoFour");
Console.WriteLine("This application was created by: Justin Spencer");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Provide input or type exit to leave\n");

do
{
	Console.Write("What is your first name? ");
    firstName = Console.ReadLine();
	firstName = firstName?.ToLower();

    if (firstName == "tim")
	{
		Console.WriteLine("Welcome, Professor.");
	}
	else if (firstName != "exit")
	{
		Console.WriteLine("Welcome, student.");
	} 
} while (firstName != "exit");



