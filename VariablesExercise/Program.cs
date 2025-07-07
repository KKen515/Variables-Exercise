namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //A program to run a Mad Libs-esque output utilizing Strings, Integers, Booleans, Decimals, Doubles, and Characters 
            
            bool codeIsRunning = true;
            
            Console.WriteLine("Name an Adjective");
            
            string adjectiveA = Console.ReadLine();
            
            Console.WriteLine("Name a time of Day (In UTC Time)");
            
            int time = Convert.ToInt32(Console.ReadLine());
            
          Console.WriteLine("Name another Adjective");
          
          string adjectiveB = Console.ReadLine();
          
          Console.WriteLine("Name a type/breed of Dog");
          
          string typeOfDog = Console.ReadLine();
          
          Console.WriteLine("Name a room in a House");
          
          string roomInAHouse = Console.ReadLine();
          
          Console.WriteLine("Name a Verb (in Past Tense)");
          
          string verbPastTense = Console.ReadLine();
          
          Console.WriteLine("Name a Favorite Activity");
          
          string favoriteActivity  = Console.ReadLine();
          
          Console.WriteLine("Name a Decimal Value");

          double poundsDouble = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Name a Favorite Drink");
          
          string favoriteDrink  = Console.ReadLine();
          
          Console.WriteLine("Name another Decimal Value");

          decimal millilitersDecimal   = Convert.ToDecimal(Console.ReadLine());

          Console.WriteLine("Name a Favorite Food");
          
          string favoriteFood  = Console.ReadLine();
          
          Console.WriteLine("Name a Character (e.g. 'A', 'F', 'Z')");

          char characterInsignia = Convert.ToChar(Console.ReadLine());
          
          Console.WriteLine("Name an Animal (Plural)");
          
          string smallAnimal = Console.ReadLine();
          
          Console.WriteLine("Name a Verb (-ing Ending)");
          
          string verb  = Console.ReadLine();
          
          Console.WriteLine("Name a Body Part (Plural)");
          
          string bodyPart  = Console.ReadLine();
          
          Console.WriteLine($"The day was a {adjectiveA}, hot day in July. I woke up at {time} to the {adjectiveB} sound of a {typeOfDog} barking just outside the {roomInAHouse} upstairs. I {verbPastTense} to the clock as I realized I was late for {favoriteActivity}. I quickly started to pack my bags, with {poundsDouble} Pounds of {favoriteFood} and {millilitersDecimal} Liters of {favoriteDrink} to get ready. When I finally found the bag with the {characterInsignia} Insignia, there were {smallAnimal} {verb} inside with huge {bodyPart} staring at my soul.");


        }
    }
}
