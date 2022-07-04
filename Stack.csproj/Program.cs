using System;
using System.Collections;

namespace StackTest.csproj
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Space");
            myStack.Pop();
            myStack.Push("World");
            myStack.Push("!");

        // Displays the properties and values of the Stack.
        Console.WriteLine( "myStack" );
        Console.WriteLine( "\tCount:    {0}", myStack.Count );
        Console.Write( "\tValues:" );
        PrintValues( myStack );
        }

        public static void PrintValues( IEnumerable myCollection ) {
            foreach (Object obj in myCollection )
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
