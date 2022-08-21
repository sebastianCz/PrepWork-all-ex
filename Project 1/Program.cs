

//Console.WriteLine("Sorted...");
/*Array.Sort(pallets);

foreach(var pallet in pallets)
{

    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed..");
Array.Reverse(pallets);

foreach(var pallet in pallets)
{

    Console.WriteLine($"--{pallet}");
}
*/
/*string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}*/
/*
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2...count:{pallets.Length}");

 foreach(var pallet in pallets)
{

    Console.WriteLine($"---{pallet}");
}
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6, count:{pallets.Length}");
pallets[4] = "CO1";
pallets[5] = "CO2";

foreach(var pallet in pallets)
{

    Console.WriteLine($"--{pallet}");

}

Console.Write("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"REsizing3...count :{pallets.Length}");

foreach ( var pallet in pallets){

    Console.WriteLine($"--{pallet}");

}
*/
/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join(",", valueArray);

Console.WriteLine(result);

string[] items = result.Split(',');
foreach(string item in items)
{

    Console.WriteLine(item); 

}
*/
/*
string pangram = "The quick brown fox jumps over the lazy dog";

string[] worlds = pangram.Split(null);
string[] result = {};
Array.Resize(ref result, worlds.Length);


for( int x = 0; worlds.Length > x;x++)
{
    char[] charArray = worlds[x].ToCharArray();
    
    Array.Reverse(charArray);
    result[x] = String.Join("", charArray);
    // var reverseResult = Array.Reverse(charArray);
    Console.Write(" "+result[x].ToString());

}*/

/*string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);*/

using System;

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderArray = orderStream.Split(',');
string[] result = { " " };
int count = 0;

for (int x = 0; x < orderArray.Length; x++) 
{
    if (orderArray[x].Contains("B")){

        count++;
       Array.Resize(ref result, count);
        result[count - 1] = orderArray[x];


        Console.WriteLine(count +" result length"+result.Length+ result[count - 1]);
    }
    

}

Array.Sort(result);
List<string> text = result.ToList();
text.ForEach(Console.WriteLine);

