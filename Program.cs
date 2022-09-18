string[] array = 
{
    "Ice,",
    "Ice",
    "Baby",
    "That's",
    "The_",
    "Motto",
    "Btw",
    "You",
    "Belong",
    "With",
    "&",
    "Me",
    "Lately I've been",
    "I've been loosing sleep",
    "(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧",
    "･ᴗ･"
};

void ArrayUnder3(string[] array)
{
    foreach (string item in array)
    {
        if(item.Length <= 3)
        {
            Console.WriteLine(item);
        }
    }
}

ArrayUnder3(array);