using System;
using System.Collections;

public class StackExamples {

    public static void Main() {

        // Create and initialize
        Stack myStack = new Stack();
        myStack.Push("Hello");
        myStack.Push("World");
        myStack.Push("!");

        // Display the properties and values of the Stack
        Console.WriteLine("myStack");
        Console.WriteLine( "\tCount:    {0}", myStack.Count );
        Console.Write( "\tValues:" );
        PrintValues( myStack );
    }

    public static void PrintValues( IEnumerable myCollection )  {
        foreach ( Object obj in myCollection )
            Console.Write( "    {0}", obj );
        Console.WriteLine();
    }
};