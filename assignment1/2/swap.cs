using System;

namespace swap {
  class ab {
    static void Main(String[] args) {
      int a = 10, b = 20;

      a = a + b;
      b = a - b;
      a = a - b;

      Console.WriteLine("Values after swapping are:");
      Console.WriteLine("a=" + a);
      Console.WriteLine("b=" + b);
    }
  }
}
