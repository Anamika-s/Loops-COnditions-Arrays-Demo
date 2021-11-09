using System;
class InitializeArray
{
  static void Main()
  {
    int [] num = new int[] {1,2,3,4};
    // Console.WriteLine("Enter Elemenets");
// for(int i=0;i<10;i++)
// {
//   num[i]= Convert.ToByte(Console.ReadLine());

// }
 Console.WriteLine("Elemenets are");
 int sum=0;
 for(int i=0;i<num.Length;i++)
{
  num[i]=100;
  sum+=num[i];
  
}
foreach(int temp in num)
{
  // temp=100;
  sum+= temp;
 Console.WriteLine(temp); 
}
float avg = (float)sum/num.Length;
Console.WriteLine("Sum is " + sum);
Console.WriteLine("Average is " + avg);

  }
}