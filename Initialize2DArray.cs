using System;
class Initialize2DArray
{
  static void Main()
  {
    int [,] num = new int[3,3] {
      {1,2,3},
      {3,4,5},
      {5,6,8}
    };
//         Console.WriteLine("Enter Elemenets");
// for(int i=0;i<3;i++)
// {
// for(int j=0;j<3;j++)
   
//   num[i,j]= Convert.ToByte(Console.ReadLine());

// }
 Console.WriteLine("Elemenets are");
 for(int i=0;i<3;i++)
{
  Console.WriteLine();
for(int j=0;j<3;j++)
{
  Console.Write(num[i,j] +  "\t");
}
}
  }
}

