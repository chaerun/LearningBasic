using System;
using System.IO;

namespace StreamReaderDemo
{
  class Program
  {
    static void Main( string[] args )
    {
      try
      {
        // Create an instance of StreamReader to read from a file.
        // The using statement also closes the StreamReader.
        using( StreamReader sr = new StreamReader( Path.Combine( Path.GetFullPath( Path.Combine( AppContext.BaseDirectory, "..\\..\\..\\" ) ), "Input.txt" ) ) )
        {
          string line;

          // Read and display lines from the file until 
          // the end of the file is reached. 
          while( ( line = sr.ReadLine() ) != null )
          {
            Console.WriteLine( line );
          }
        }
      }
      catch( Exception e )
      {
        // Let the user know what went wrong.
        Console.WriteLine( "The file could not be read:" );
        Console.WriteLine( e.Message );
      }
      Console.ReadKey();
    }
  }
}