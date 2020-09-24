using System;
using System.Diagnostics;

namespace AttributesDemo
{
  class Program
  {
    [DebuggerDisplay( "Hello {FirstName} {LastName}!" )]
    [Serializable]
    public class Person
    {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      [DebuggerBrowsable( DebuggerBrowsableState.RootHidden )]
      public int[] WorkingDays { get; set; }
    }

    static void Main( string[] args )
    {
      var person = new Person
      {
        FirstName = "Chaerun",
        LastName = "Muhaimin",
        WorkingDays = new int[] { 1, 2, 3, 4 }
      };
      Display( person );

      if( Attribute.IsDefined( typeof( Person ), typeof( DebuggerDisplayAttribute ) ) )
      {
        Console.WriteLine( "Defined" );
      }
      
      Console.ReadLine();
    }

    [Conditional( "Release" )]
    public static void Display( Person person )
    {
      Console.WriteLine( person.FirstName );
    }
  }
}
