Console.Clear();
int [] array = new int[12];
int size=array.Length;

int index=0;

while (index<size)
{
    array[index] =new Random().Next(-9,10); 
    index++;
}
Console.WriteLine($"[{String.Join(";", array)}]");

for (int startIndex=0; startIndex<size;startIndex++)
{
    array[startIndex]*=-1;
    
}
Console.WriteLine($"Поменяли значения [{String.Join(";",array)}]");
