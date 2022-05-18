Console.WriteLine("Enter digit:");
int num = int.Parse(Console.ReadLine());
int Saturday = 6;
int Sunday = 7;
if (num == Saturday ^ num == Sunday) Console.WriteLine("This is a weekend!");
else Console.WriteLine("This is not a weekend!");