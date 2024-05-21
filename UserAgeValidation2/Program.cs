//rakendus küsib kasutajalt vanuse
//kui kasutaja vanus on väiksem kui 13, siis kuvatakse: "You are too young to use Instagram"
//muul juhul konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");
string userAge = Console.ReadLine();
int userAgeNum = 0;
bool isAgeNum = Int32.TryParse(userAge, out userAgeNum);
Console.WriteLine($"Parse result {isAgeNum}. User is {userAgeNum} years old.");
if(isAgeNum)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}

