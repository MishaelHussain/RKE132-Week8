string folderPath = @"C:/data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";



string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
string[] villains = { "Voldemort", "Darth Vader", "Dracula,", "Joker", "Sauron" };
string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "Lego brick" };



string hero = GetRandomValueFromArray(heroes); 
string heroWeapon = GetRandomValueFromArray(weapon);
int heroHP = GeCharacterHP(hero);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
int villainHP = GetCharacterHP(villain);
Console.WriteLine($"Today {villain} tries to take over the world");


    static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}

static int GetCharacterHP(string characterName)
{
    if(characterName.Lenght < 10)
    {
        return 10;
    } 
    else
    {
        return characterName.Length;
    }
}

static int Hit(int characterHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);

    if(strike == 0)
    {
        Console.WriteLine($"{characterName} missed the target!");

    }
    else if(strike == characterHP  -1)
    {
        Console.WriteLine($"{characterHP} made a critical hit!");
    } 
    else
    {
        Console.WriteLine($"{CharacterNmae} hit {strike}!");
    } 

    return strike;
}
