
using withDictionaryTask;
while (true)
{
    List<Cars> carsnumber = new List<Cars>()
{ new Cars(){CarsNumber="10AA042" },
  new Cars(){CarsNumber= "10AA056"},
  new Cars(){CarsNumber= "10AA037"},
  new Cars(){CarsNumber="10AA078" }
};
    foreach (var cars in carsnumber)
    {
        Console.WriteLine($"Avtomobilin nomresi:{cars.CarsNumber}");
    }
    Console.WriteLine("Siyahidaki avtomobilin sahibini bilmek ucun:1");
    Console.WriteLine("Siyahidaki sexsin cerimesini bilmek ucun:2");
    Console.Write("Secimi daxil edin:"); int choice = int.Parse(Console.ReadLine());
    string owner = "Sahib";
    Dictionary<string, Dictionary<string, Person>> info = new Dictionary<string, Dictionary<string, Person>>();
    info.Add("10AA042", new Dictionary<string, Person>
{
    {owner,new Person{Name="Lale", Fines=123} }
});
    info.Add("10AA056", new Dictionary<string, Person>
{
    {owner,new Person{Name="Samir", Fines=100} }
});
    info.Add("10AA037", new Dictionary<string, Person>
{
    {owner,new Person{Name="Mehriban", Fines=140} }
});
    info.Add("10AA078", new Dictionary<string, Person>
{
    {owner,new Person{Name="Samir", Fines=200} }
});
    switch (choice)
    {
        case 1:
            Console.Write("Avtomobilin nomresini daxil edin:"); string number1 = Console.ReadLine();
            Console.WriteLine($"Bu {number1}-li avtomobil {info[number1][owner].Name}indir");
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            Console.Write("Avtomobilin nomresini daxil edin:"); string number2 = Console.ReadLine();
            Console.WriteLine($"Bu {number2}-li avtomobil {info[number2][owner].Name}indir ve cerimesi {info[number2][owner].Fines}azn-dir");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}