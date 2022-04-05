int sideA, sideB, sideC;
Console.WriteLine("\t Enter The length of side A");
sideA = int.Parse(Console.ReadLine());
Console.WriteLine("\t Enter the length of side B");
sideB = int.Parse(Console.ReadLine());
Console.WriteLine("\t Enter the length of side C");
sideC = int.Parse(Console.ReadLine());

if (sideA <= 0 || sideB <= 0 || sideC <= 0)
{
    Console.WriteLine("Some of the lengths entered are invaild");
}
else if (sideA * sideA == sideB * sideB + sideC * sideC || sideB * sideB == Math.Pow(sideA, 2) + Math.Pow(sideC, 2) || Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2))
{
    Console.WriteLine("YAYYY THIS IS A RIGHT ANGLE TRIANGLE");
}
else
{
    Console.WriteLine("Sorrry please try again");
}











   