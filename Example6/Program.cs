// See https://aka.ms/new-console-template for more information
int a = 1;
int b = 2;
int c = 6;
int e = 8;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);
