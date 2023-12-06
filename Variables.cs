namespace Variables;

class Program
{
    static void Main(string[] args)
    {
        // * - Data Types -
        // byte: 4 bytes | Stores whole numbers from 0 to 255
        byte number = 2;
        // int: 4 bytes | Stores whole numbers from -2,147,483,648 to 2,147,483,647
        int count = 10;
        // float: 4 bytes | Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
        float totalPrice = 20.95f;
        // char: 2 bytes | Stores a single Unicode character
        char character = 'A';
        // string: Variable | Stores a sequence of characters
        string firstName = "Georgie";
        // bool: 1 byte | Stores true or false values
        bool isWorking = true;


        // * Logging Data Types
        System.Console.WriteLine(number);
        System.Console.WriteLine(count);
        System.Console.WriteLine(totalPrice);
        System.Console.WriteLine(character);
        System.Console.WriteLine(firstName);
        System.Console.WriteLine(isWorking);

        // * - Format String -
        // Template for logging
        // '{0}' represents: byte.MinValue
        // '{1}' represents: byte.MaxValue
        System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // Output: 0 255 (min and max values of byte)
        System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue); // Output: -3.4028235E+38 3.4028235E+38 (min and max values of float)

        // * - Type Conversion -
        // Implicit Type
        byte a = 1;
        int b = a;

        // Explicit Type Conversion
        int c = 1000;
        byte d = (byte) c;
        System.Console.WriteLine("byte d is: {0}", c);

        // Non-Compatible Type Conversion
        try
        {
            
        string str = "true";
        bool i = Convert.ToBoolean(str); // Converting using Convert class
        System.Console.WriteLine("int i is: {0}", i);
        }
        catch (System.Exception)
        {
            Console.WriteLine("The number could not be converted to a byte.");
        }

    // * - Operations -
        var e = 10;
        var f = 3;
        System.Console.WriteLine((float)e / (float)f); // if you want to get a certain datatype output
    }
}
