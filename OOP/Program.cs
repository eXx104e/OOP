
enum Size
{
    большой = 0,
    средний = 1,
    маленький = 2
}

enum Benefit
{
    полезно = 0,
    вредно = 1 
}

enum Sex
{
    мужской = 0,
    женский = 1
}
abstract class Person
{
    public string surname { get; protected set; }
    public string firstname { get; protected set; }
    public string patronymic { get; protected set; }
    public Sex sex { get; protected set; }
    public byte age { get; protected set; }
    public byte growth { get; protected set; }
    public byte weight { get; protected set; }
    

}

class Client : Person
{
    public string wealth { get; protected set; }
    public string appearance { get; protected set; }
    public string favourite_cuisine { get; protected set; }
    public string allergic { get; protected set; }
    public string favourite_dish { get; protected set; }

    public Client(string surname, string firstname, string patronymic, Sex sex, byte age, byte growth, byte weight, string wealth, string appearance,
     string favourite_cuisine, string allergic, string favourite_dish)
    {
        this.surname = surname;
        this.firstname = firstname;
        this.patronymic = patronymic;
        this.sex = sex;
        this.age = age;
        this.growth = growth;
        this.weight = weight;
        this.wealth = wealth;
        this.appearance = appearance;
        this.favourite_cuisine = favourite_cuisine;
        this.allergic = allergic;
        this.favourite_dish = favourite_dish;
    }

    public Client(string surname, string firstname, string patronymic, Sex sex, byte age, byte growth, byte weight, string wealth, string appearance)
    {
        this.surname = surname;
        this.firstname = firstname;
        this.patronymic = patronymic;
        this.sex = sex;
        this.age = age;
        this.growth = growth;
        this.weight = weight;
        this.wealth = wealth;
        this.appearance = appearance;
    }
    public void PrintClient(Client client)
    {
        Console.WriteLine($"Имя: {client.firstname}, Фамилия: {client.surname}, Отчество: {client.patronymic}, Предпочтения: {client.favourite_cuisine}, Любимое блюдо: {client.favourite_dish}, Пол: {client.sex}\n");
    }
    public string ClientAlergies(Client client)
    {
        switch (client.allergic)
        {
            case "Глютен":
                return "нельзя хлебобулочные изделия";
            case "Орехи":
                return "нельзя блюда с орехами";
            case "Лактоза":
                return "нельзя молочные продукты";
            case "нет":
                return "все можно";
        }
        return "";
    }
}

class Personnel : Person
{
    byte length_of_service { get; set; }
    string qualification { get; set; }
    string post { get; set; }
    string respect { get; set; }
    string education { get; set; }
    int salary { get; set; }
    public string GetFullPersonnel { get {return $"Фамилия:{this.surname}, Имя:{this.firstname}, Отчество:{this.patronymic}, Пол:{this.sex}, Возраст:{this.age}, Рост:{this.growth}, Вес:{this.weight}, Стаж:{this.length_of_service}, Квалификация:{this.qualification}, Должность:{this.post}, Мнение общества:{this.respect}, Образование:{this.education}, Зарплата:{this.salary}\n"; } }

    public Personnel(string surname, string firstname, string patronymic, Sex sex, byte age, byte growth, byte weight, byte length_of_service, string qualification,
    string post, string respect, string education, int salary)
    {
        this.surname = surname;
        this.firstname = firstname;
        this.patronymic = patronymic;
        this.sex = sex;
        this.age = age;
        this.growth = growth;
        this.weight = weight;
        this.length_of_service = length_of_service;
        this.qualification = qualification;
        this.post = post;
        this.respect = respect;
        this.education = education;
        this.salary = salary;
    }

    public Personnel(string surname, string firstname, string patronymic, Sex sex, byte age, string post, string education)
    {
        this.surname = surname;
        this.firstname = firstname;
        this.patronymic = patronymic;
        this.sex = sex;
        this.age = age;
        this.post = post;
        this.education = education;
    }

}
class Cafe
{
    string name;
    string adress;
    string working_hours;

    public Cafe(string name, string adress, string working_hours)
    {
        this.name = name;
        this.adress = adress;
        this.working_hours = working_hours;

    }

    public Personnel ApplyForAJob(Person person, string name, string surname, string patronomic, Sex sex, byte age, string post, string education)
    {
       person  = new Personnel(surname, name, patronomic, sex, age, post, education);
       return (Personnel)person;
    }
}

abstract class Food
{
    protected string name;
    protected double grams;
    protected int calories;
    protected Benefit benefit;
    protected Size size;
    protected string ingredients;
    protected double cost;
}

class Dishes : Food
{
    string cuisine;
    public string GetInfoAboutPosition
    {
        get { return $"{this.name}, {this.grams}, {this.calories}, {this.benefit}, {this.size}, {this.ingredients}, {this.cost}, {this.cuisine}"; }

    }
    public string GetName
    {
        get { return name; }
    }
    public double GetCost
    {
        get { return this.cost; }
    }

    public Dishes(string name, int calories, int grams, string ingredients, string cuisine, double cost)
    {
        this.name = name;
        this.calories = calories;
        this.grams = grams;
        this.ingredients = ingredients;
        this.cuisine = cuisine;
        this.cost = cost;
    }


}
class Drinks : Food
{
    double percentage_of_alchool;
    double volume;
    public string GetInfoAboutPosition
    {
        get { return $"{this.name}, {this.grams}, {this.calories}, {this.benefit}, {this.size}, {this.ingredients}, {this.cost}, {this.percentage_of_alchool}, {this.volume}"; }

    }
    public string GetName
    {
        get { return name; }
    }
    public double GetCost
    {
        get { return this.cost; }
    }
    public Drinks(string name, int calories, int grams, string ingredients, double percentage_of_alchool, double volume, double cost)
    {
        this.name = name;
        this.calories = calories;
        this.grams = grams;
        this.ingredients = ingredients;
        this.percentage_of_alchool = percentage_of_alchool; 
        this.volume = volume;
        this.cost = cost;
    }

}
class Items
{
    public string material { get; set; }
    public int cost { get; set; }
    public string size { get; set; }
    public byte quantity { get; set; }
}

class Furniture : Items
{
    public string quality { get; set; }
    public string comfort { get; set; }
    public string colour { get; set; }

    public Furniture(string material, int cost, string size, byte quantity, string quality, string comfort, string colour)
    {
        this.material = material;
        this.cost = cost;
        this.size = size;
        this.quantity = quantity;
        this.quality = quality;
        this.comfort = comfort;
        this.colour = colour;
    }
}

class Program
{
    static public void PrintMenu(Dishes n1, Drinks n2,Drinks n3)
    {
        Console.WriteLine($"1:{n1.GetName}\n2:{n2.GetName}\n3:{n3.GetName}\n");
    }
    static public void Paras(params int[] n)
    {
        Console.WriteLine(String.Join(" ", n));
    }
    static void Main(string[] args)
    {
        Dictionary<string, string> Alergies = new Dictionary<string, string>
        {
            ["Лактоза"] = "Молочные продукты",
            ["Глютен"] = "Хлебобулочные изделия",
            ["Орехи"] = "Блюда с орехами"
        };
        string path = @"C:\Users\79674\source\repos\OOP\OOP\TextFile1.txt";
        string[] str = File.ReadLines(path).Select(x => x.ToString()).ToArray();
        string[] str1 = str[0].Split(", ").ToArray();
        string[] str2 = str[1].Split(", ").ToArray();
        string[] str3 = str[2].Split(", ").ToArray();
        string[] str4 = str[3].Split(", ").ToArray();
        string[] str5 = str[4].Split(", ").ToArray();
        string[] str6 = str[5].Split(", ").ToArray();
        string[] str7 = str[6].Split(", ").ToArray();
        string[] str8 = str[7].Split(", ").ToArray();
        string[] str9 = str[8].Split(", ").ToArray();
        string[] str13 = str[12].Split(", ").ToArray();
        string[] str14 = str[13].Split(", ").ToArray();
        string[] str15 = str[14].Split(", ").ToArray();
        string[] str16 = str[15].Split(", ").ToArray();


        Client client1 = new Client(str1[0], str1[1], str1[2], (Sex)int.Parse(str1[3]), byte.Parse(str1[4]), byte.Parse(str1[5]), byte.Parse(str1[6]), str1[7], str1[8], str1[9], str1[10], str1[11]);
        Client client2 = new Client(str2[0], str2[1], str2[2], (Sex)int.Parse(str2[3]), byte.Parse(str2[4]), byte.Parse(str2[5]), byte.Parse(str2[6]), str2[7], str2[8], str2[9], str2[10], str2[11]);
        Client client3 = new Client(str3[0], str3[1], str3[2], (Sex)int.Parse(str3[3]), byte.Parse(str3[4]), byte.Parse(str3[5]), byte.Parse(str3[6]), str3[7], str3[8], str3[9], str3[10], str3[11]);
        Client client4 = new Client(str4[0], str4[1], str4[2], (Sex)int.Parse(str4[3]), byte.Parse(str4[4]), byte.Parse(str4[5]), byte.Parse(str4[6]), str4[7], str4[8], str4[9], str4[10], str4[11]);
        Client client5 = new Client(str5[0], str5[1], str5[2], (Sex)int.Parse(str5[3]), byte.Parse(str5[4]), byte.Parse(str5[5]), byte.Parse(str5[6]), str5[7], str5[8], str5[9], str5[10], str5[11]);
                                                               
        Personnel waiter = new Personnel(str6[0], str6[1], str6[2], (Sex)int.Parse(str6[3]), byte.Parse(str6[4]), byte.Parse(str6[5]), byte.Parse(str6[6]), byte.Parse(str6[7]), str6[8], str6[9], str6[10], str6[11], int.Parse(str6[12]));
        Personnel chef = new Personnel(str7[0], str7[1], str7[2], (Sex)int.Parse(str7[3]), byte.Parse(str7[4]), byte.Parse(str7[5]), byte.Parse(str7[6]), byte.Parse(str7[7]), str7[8], str7[9], str7[10], str7[11], int.Parse(str7[12]));
        Personnel cook = new Personnel(str8[0], str8[1], str8[2], (Sex)int.Parse(str8[3]), byte.Parse(str8[4]), byte.Parse(str8[5]), byte.Parse(str8[6]), byte.Parse(str8[7]), str8[8], str8[9], str8[10], str8[11], int.Parse(str8[12]));
        Personnel administrator = new Personnel(str9[0], str9[1], str9[2], (Sex)int.Parse(str9[3]), byte.Parse(str9[4]), byte.Parse(str9[5]), byte.Parse(str9[6]), byte.Parse(str9[7]), str9[8], str9[9], str9[10], str9[11], int.Parse(str9[12]));

        Furniture table = new Furniture(str13[0], int.Parse(str13[1]), str13[2], byte.Parse(str13[3]), str13[4], str13[5], str13[6]);
        Furniture chair = new Furniture(str14[0], int.Parse(str14[1]), str14[2], byte.Parse(str14[3]), str14[4], str14[5], str14[6]);
        Furniture dish0 = new Furniture(str15[0], int.Parse(str15[1]), str15[2], byte.Parse(str15[3]), str15[4], str15[5], str15[6]);
        Furniture mug = new Furniture(str16[0], int.Parse(str16[1]), str16[2], byte.Parse(str16[3]), str16[4], str16[5], str16[6]);

        Console.WriteLine("Кафе: <<Claude Mone>>");
        Console.ReadKey();
        Console.WriteLine("Список клиентов:");
        client1.PrintClient(client1);
        client2.PrintClient(client2);
        client3.PrintClient(client3);
        client4.PrintClient(client4);
        client5.PrintClient(client5);
        Console.ReadKey();

        Console.WriteLine($"Клиенту {client1.firstname} {client1.ClientAlergies(client1)}\n");
        Console.WriteLine($"Клиенту {client2.firstname} {client2.ClientAlergies(client2)}\n");
        Console.WriteLine($"Клиенту {client3.firstname} {client3.ClientAlergies(client3)}\n");
        Console.WriteLine($"Клиенту {client4.firstname} {client4.ClientAlergies(client4)}\n");
        Console.WriteLine($"Клиенту {client5.firstname} {client5.ClientAlergies(client5)}\n");
        Console.ReadKey();

        Cafe mac = new Cafe("Claude Mone", "Осипенко 20", "08:00 - 20:00");
        string[] str10 = str[9].Split("; ").ToArray();
        Dishes dish1 = new Dishes(str10[0], int.Parse(str10[1]), int.Parse(str10[2]), str10[3], str10[4], double.Parse(str10[5]));
        string[] str11 = str[10].Split(", ").ToArray();
        Drinks dish2 = new Drinks(str11[0], int.Parse(str11[1]), int.Parse(str11[2]), str11[3], double.Parse(str11[4]), double.Parse(str11[5]), double.Parse(str11[6]));
        string[] str12= str[11].Split(", ").ToArray();
        Drinks dish3 = new Drinks(str12[0], int.Parse(str12[1]), int.Parse(str12[2]), str12[3], double.Parse(str12[4]), double.Parse(str12[5]), double.Parse(str12[6]));
        Console.ReadKey();

        Console.WriteLine("Список персонала:");
        Console.WriteLine(waiter.GetFullPersonnel);
        Console.WriteLine(chef.GetFullPersonnel);
        Console.WriteLine(cook.GetFullPersonnel);
        Console.WriteLine(administrator.GetFullPersonnel);
        Console.ReadKey();

        Console.WriteLine("У нас есть:");
        PrintMenu(dish1, dish2, dish3);
        Console.WriteLine("Введите номер желаемого блюда.");
        try
        {
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
                Console.WriteLine($"C вас: {dish1.GetCost} рублей");
            else if (num == 2)
                Console.WriteLine($"C вас: {dish2.GetCost} рублей");
            else if(num == 3)
                    Console.WriteLine($"C вас: {dish3.GetCost} рублей");

        }
        catch(FormatException)
        {
            Console.WriteLine("Введи cуществующую позицию!");
        }       
    }

}


    