using System;
using System.IO;

namespace StreamWriterDemo
{
  class Program
  {
    static void Main( string[] args )
    {
      string[] names = new string[] { "Zara Ali", "Nuha Ali" };

      using( StreamWriter sw = new StreamWriter( "Names.txt" ) )
      {

        foreach( string s in names )
        {
          sw.WriteLine( s );
        }
      }

      // Read and show each line from the file.
      string line = "";
      using( StreamReader sr = new StreamReader( "Names.txt" ) )
      {
        while( ( line = sr.ReadLine() ) != null )
        {
          Console.WriteLine( line );
        }
      }
      Console.ReadKey();
    }
  }
}