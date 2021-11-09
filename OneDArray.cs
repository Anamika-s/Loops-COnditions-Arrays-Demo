using System;
class OneDArray
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
// for(int i=0;i<10;i++)
// {
//  Console.WriteLine(num[i]);

// }
foreach(int temp in num)
{
 Console.WriteLine(temp); 
}

  }
}