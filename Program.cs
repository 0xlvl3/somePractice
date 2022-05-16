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

//Common errors with methods
//--------------------------

////error CS0161 needs a return statement within the body of the method
//static string ThisNeedsAReturn(string test) 
//{ Console.WriteLine($"{test} this will throw error because there is no return"); }

////this error CS1520 needs a method type of int instead of void
//static void NeedsAReturn()
//{
//    int value = 0;
//    return value;
//}

////CS0029 will be thrown when you use an incorrect value type
////in this example we label the type as int when it should be a string
//static int ThisMethodShouldBeAString()
//{
//    string name = "dog";
//    return name;
//}

//----------------------------------------------------------------
//testing Int32.TryParse with out parameters

string ageAsString = "102";
string nameAsString = "Granny";

int ageAsInt;
bool outcome;
//converting ageAsString to int also then logging them both to console to see if values are correct
outcome = Int32.TryParse(ageAsString, out ageAsInt);
Console.WriteLine(ageAsInt);
Console.WriteLine(outcome);


NextLine();

int nameAsInt;
bool outcome2;
//same as above
outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
Console.WriteLine(nameAsInt);
Console.WriteLine(outcome2);

//defining the variables before using them within the Whisper method
string statement = "THIS SHOULD BE LOWERCASE";
bool IsWhisperTrue = true;
//calling Whisper method with variables above
string thisString = Whisper(statement, out IsWhisperTrue);

Console.WriteLine(thisString);

//using out parameters with a method now, if true text should be lowercase
static string Whisper(string text, out bool value)
{
    value = true;
    return text.ToLower();
}

NextLine();
//Codecademy task
//task was to replicate floor plans for a job, then add them all together in total cost
//using methods to get the values

//testing out the methods to see if we get the correct values
double testRectangle = Rectangle(4, 5);
Console.WriteLine(testRectangle);

double newCircle = Circle(4);
Console.WriteLine(newCircle);

double newTriangle = Triangle(10, 9);
Console.WriteLine(newTriangle);

//these are the actual values we required for the job
double costTriangle = Triangle(750, 500);
double costCircle = Circle(375);
double costRectangle = Rectangle(1500, 2500);
double costInPeso = 180;

NextLine();
//checking those values
Console.WriteLine(costRectangle);
Console.WriteLine(costCircle / 2);
Console.WriteLine(costTriangle);

NextLine();
//putting them all together for the total cost of the floor plan 
double floorPlanCost = costTriangle + costCircle + costRectangle / 2 * costInPeso;
//using math.round to round the floor plan to the decimal place that was required which was 2
Console.WriteLine($"The current cost of the floor plan all totaled will be {Math.Round(floorPlanCost, 2)} peso");

//next job is to create a method for the total cost of the floor plan


//method for getting the area of rectangle
static double Rectangle(double length, double width)
{
    return length * width;
}

//method for getting the area of circle
static double Circle(double radius)
{
    return Math.PI * Math.Pow(radius, 2);
}

//method for getting area of triangle
static double Triangle(double bottom, double height)
{
    return 0.5 * bottom * height;
}


//method for \n 
static void NextLine() { Console.WriteLine("\n"); }
