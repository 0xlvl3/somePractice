Console.Title = "Practice while away";

//we define a variable string
string designer = "Anders Hejlsberg";
//we use IndexOf method to find the starting letter of the second name and place it in a new variable
int indexOfSpace = designer.IndexOf("H");
//check to see if it worked
Console.WriteLine(indexOfSpace);
//then use that with another method called substring and the new variable we created
string secondName = designer.Substring(indexOfSpace);
Console.WriteLine(secondName);

NextLine();

RandomNumber();
//creating a randomnumber method
static void RandomNumber()
{
    //using the random class we make a new instance in random
    Random random = new Random();
    //we then create a int num then use the random instance we just created with the method Next();
    //Next will generate random numbers based on the seed value
    //if we give the Next method args we can create the range it gives back
    //here our random number will be between 1 - 100
    int num = random.Next(1, 100);
    Console.WriteLine(num);
}

NextLine();

RandomDouble();

//Same as our int random but this time using the double 
static void RandomDouble()
{
    Random randomDouble = new Random();
    double num = randomDouble.NextDouble();
    Console.WriteLine(num);

}

NextLine();

//calling method with default args
VisitPlanets();
//calling method but using changing the name arg
VisitPlanets(name: "dog");
//calling method but using all three args
VisitPlanets("wild", "dave", 10);

static void VisitPlanets(string adjective = "brave", string name = "kyle", int numberOfPlanets = 2)
{
    Console.WriteLine($"Welcome back {adjective} {name} you have visited {numberOfPlanets}");

}

NextLine();






static void NextLine() { Console.WriteLine("\n"); }
