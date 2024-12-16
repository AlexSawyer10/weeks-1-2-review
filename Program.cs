namespace Weeks_1_2_Review;

class Program
{
    public const ConsoleColor P1_COLOR = ConsoleColor.Cyan; //Make anything related to using P1_Color Cyan?
    public static bool p1Turn = true;
    static void Main()
    {
        Console.WriteLine(Environment.NewLine); // Just shows others that It was meant to be done (same thing as Console.WriteNewLine)
        Console.WriteLine(); //same thing here 
        
       

        int stringInterpelation = 2;
        Console.WriteLine($"The number is {stringInterpelation}."); // String interpolation

        char whosTurn = p1Turn ? '1' : '2'; //if true or if false
        
        Console.WriteLine("Enter text ");
        String text = Console.ReadLine();
        Console.WriteLine(text);
        Console.ForegroundColor = P1_COLOR; //Should color the text?

        String joint = "This is a test";
        String firstSubstring = joint.Substring(5, 8); //Should print "is". 
        joint = joint.Replace('','').Replace(',',' ,'); // What's the arguments for this?
        joint = String.Join("test", firstSubstring); //Where does this join together?
        
        
        
        Console.WriteLine("Enter a number :");
        String number = Console.ReadLine().Trim(); //Trim cuts off the extra spaces if any???
        if (int.TryParse(number, out number))
        {
            
        }
        
            
        List<int> test = new List<int> { 1, 2, 3, 4 }; //Lists do not have a fixed size. Arrays do. You can keep adding numbers
        int absValue = Math.Abs(test[0]); //Absolute value is the length from the number to zero
        int mathMinValue = Math.Min(test[0], test[1]); //used to find the smaller of the two numbers What if I want to find the smallest number of the entire list?
        int mathMaxValue = Math.Max(test[0], test[1]); //used to find the larger of the two numbers. What if I want to find the largest number of the entire list?
        
        int[] columnNumbers = Enumerable.Range(1,4).ToArray();
        int[] columnNumbersDifferent = { 1,2,3,4}; //Same thing 
        
        int[][] matrix = new int[columnNumbers.Length][]; // length would be 4
        //create the width of the 2D array?
        
        //Print 2D array
        for (int i = 1; i < columnNumbers.Length; i++) // Let's say I want the width to be 5
        {
            Console.WriteLine($"The width of the array is {columnNumbers[i]}.");
        }

        foreach (columnNmbers row in board). //print array)  it's something like this ConsoleColo[] row in board)
        {
            
        }
        
        
        Console.Clear(); // clears the terminal
    }
    
}