
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); ;

Console.WriteLine(Recurrsion.RecurrsionCSharp.Recurrsion.PowerFactorial(2, 3));
Recurrsion.RecurrsionCSharp.Recurrsion.SubSequence("abc",0,"");

Recurrsion.RecurrsionCSharp.Recurrsion.PrintNumber5To1(5);
Recurrsion.RecurrsionCSharp.Recurrsion.PrintSumofNNaturalNo(1,5,0);

//Fibonacci
// Print 1 and 2 terms before call
int a = 0,b=1;
Console.WriteLine(a);
Console.WriteLine(b);
// Now enter terms like n= 7 
// 1 and 2 terms already print so we will pass n-2;
int n = 7;
Recurrsion.RecurrsionCSharp.Recurrsion.fibonacci(a,b,n-2);

Console.ReadLine();