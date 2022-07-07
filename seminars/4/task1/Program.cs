Console.WriteLine("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());
 int sum =0;
// for(int i =1;i<=A;i++)
// {
//     sum+=i;
// }
 int i =1;
while(i<=A)
{
    sum+=i;
    i++;
}
Console.WriteLine(sum);