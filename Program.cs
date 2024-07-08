using MHA_TEST;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    //declaring time as nullable 
    static DateTime? time;

    //creating an instance for class Languages
    public static Languages languages = new Languages();

    //creating an instance for class Addition
    public static Addition addition = new Addition();

    //interface MyInterface and classes Bongani and GetDetails are demostrating Constructor injection
    //Constructor injection is the most common form of dependency injection.
    //Dependencies are provided through the class's constructor
    //creating an inteface to be used by other classes
    public interface MyInterface
    {
        //calling method
        void details();
    }

    //creating a class to inherint interface
    public class Bongani: MyInterface
    {
        public void details()
        {
            //my details
            Console.WriteLine("Personal Details: \n" +
                "Name: Bongani\n" +
                "Surname: Chauke\n" +
                "Occupation: Student\n");
        }
    }

    
    public class GetDetails
    {
        //declaring a variable
        private readonly MyInterface _myInterface;

        //contructor injection
        public GetDetails(MyInterface myInterface)
        {
            _myInterface = myInterface;
        }

        //creating a method
        public void ConstructorInjection()
        {
            //using the injected constructor
            _myInterface.details();
        }

        //implementing property injection
        public Bongani? GetBongani { get; set; }

        //creating a method to implement property injection
        public void PropertyInjection()
        {
            GetBongani?.details();
        }

        //method injection using a parameter
        public void MethodInjection(Bongani bongani)
        {
            bongani.details();
        }

        
    }

    public static async Task Main(string[] args)
    {
        //try catch for error handling 
        try
        {
            //Test 1
            string text = "Racecar";
            var results = Enumerable.SequenceEqual(text.ToCharArray(), text.ToCharArray().Reverse());

            //Test 2 
            string texts = "racecar";
            var result = Enumerable.SequenceEqual(texts.ToCharArray(), texts.ToCharArray().Reverse());

            //to view the output
            Console.WriteLine($"Return Results for test 1: {results} \n" +
                $"Return Results for test 2: {result} \n");

            //Assign time value to time
            time = DateTime.Now;

            //check if time object can be of null value?
            if (time == null)
            {
                Console.WriteLine("Time not found? ");
            }
            else
            {

                Console.Write($"Your Time is: {time}\n");
                Console.Write("_____________________________________________________");
            }
            Console.Write("\n\n");

            //Begin [Constructor injection Implementation and results]
            //creating an instance object of class Bongani
            Bongani bongani = new Bongani();

            //Injecting the GetDetails class as a constructor
            GetDetails details = new GetDetails(bongani);

            //calling the method on GetDetails class
            Console.WriteLine("******************* Constructor Injection *******************\n");
            details.ConstructorInjection();
            //End [Constructor injection]

            //Begin [Property Injection Implementation and results]
            //using instance of Bongani class
            Console.WriteLine("******************* Property Injection *******************\n");
            details.GetBongani = bongani;// Injecting Bongani Class into GetDetails 
            details.PropertyInjection();// calling the method
            // End [Constructor injection]

            //Begin [Method Injection Implementation and results]
            Console.WriteLine("******************* Method Injection *******************\n");
            details.MethodInjection(bongani);// calling the method with the argument
            // End [Method Injection]

            //calling the method from languages class
            languages.Result();

            Console.Write("\n");
            Console.Write("\n******************* Addition Game *******************\n");
            Console.Write("\n");
            //implementating async
            //prompt user for input x
            Console.Write("Enter the First  value : ");
            int x = Convert.ToInt32(Console.ReadLine());

            //prompt user for input y
            Console.Write("Enter the Second value : ");
            int y = Convert.ToInt32(Console.ReadLine());

            //call the addition method and awaits the async method 
            int additionResults = await addition.AddNum(x, y);
            
            //display addition results
            Console.Write("\nYour answer is..." + additionResults + "\n");
        }
        catch (Exception e)
        {
            //Displays message 
            Console.WriteLine("Error has occurred " + e.Message + "\n");
        }
        
    }
}