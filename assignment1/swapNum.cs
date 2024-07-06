using System;
class swapNum {
  static void Main(String[] args){
    int a = 1;
    int b= 2;
    int temp;
    Console.WriteLine($"Before swapping: a = {a} , b = {b}");

    temp = a;
    a=b;
    b= temp;

    Console.WriteLine($"After swapping: a = {a} , b = {b}");
  }
}
