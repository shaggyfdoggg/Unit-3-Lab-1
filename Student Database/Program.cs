//arrays
string[] names = { "Justin Jones", "Zach Buth", "Omar Abdulla", "Ethan Thomas", "Joe Heath", "Forrest Verellen", "Doug Chu", "Maya Araquil", "Shane Chastain", "Timothy Montague", "Maria Ragone" };
string[] towns = { "Columbus", "Grand Rapids", "Dearborn", "Rolla", "Howell", "Traverse City, MI", "Poughkeepsie", "West bloomfield", "Rochester Hills", "Clio", "Farmington Hills" };
string[] foods = { "Baja Blast", "Pizza", "Cheese Pizza", "Hot Wings", "Tacos", "Spaghetti", "Sushi", "Sinigang", "Pizza", "Mole", "Lasagna" };

foreach (string n in names)
{
    Console.WriteLine(n);
}
bool loop = true;

Console.Write("Welcome! ");
    do
    {
        //questions
        Console.WriteLine($"Which student would you like to hear about? Enter a number 1 - {names.Length}");
        int studentChoice = int.Parse(Console.ReadLine());
        if (studentChoice <= names.Length && studentChoice >= 1)
        {
            Console.WriteLine($"Student {studentChoice} is {names[studentChoice - 1]} What would you like to know? Enter 'hometown' or favorite food.'");
            bool runStudent = true;
            while (runStudent)
            {
                string studentInfo = Console.ReadLine().ToLower().Trim();
                if (studentInfo.Contains("town") || studentInfo.Contains("home"))
                {
                    Console.WriteLine($"{names[studentChoice - 1]} is from {towns[studentChoice - 1]}");
                    runStudent = false;
                }
                else if (studentInfo.Contains("food") || studentInfo.Contains("fav"))
                {
                    Console.WriteLine($"{names[studentChoice - 1]}'s favorite food is {foods[studentChoice - 1]}");
                    runStudent = false;
                }
                else
                {
                    Console.WriteLine("That category does not exist. Please Try again. Enter 'hometown' or 'favorite food'");

                }
            }
            bool choiceLoop = true;
            do
            {

                Console.WriteLine("Would you like to learn about another student? Enter 'y' or 'n':");
                string userChoice = Console.ReadLine().ToLower().Trim();

                if (userChoice == "y")
                {
                    loop = true;
                    choiceLoop = false;
                }
                else if (userChoice == "n")
                {
                    Console.Write("Goodbye!");
                    loop = false;
                    choiceLoop = false;
                }
                else
                {
                    Console.WriteLine("Please try again");
                    choiceLoop = true;
                }

            } while (choiceLoop != false);
        }

        else
        {
            Console.WriteLine("Number is out of range. Please try again");
        }

    } while (loop != false);
