using System;
class SumAndAvg
{
  static void Main()
  {
    int [] num = new int[10];
    Console.WriteLine("Enter Elemenets");
for(int i=0;i<10;i++)
{
  num[i]= Convert.ToByte(Console.ReadLine());

}
 Console.WriteLine("Elemenets are");
 int sum=0;
foreach(int temp in num)
{
  sum+= temp;
 Console.WriteLine(temp); 
}
float avg = (float)sum/10;
Console.WriteLine("Sum is " + sum);
Console.WriteLine("Average is " + avg);

  }
}