int hero= 10;
int monster = 10;
Random attack = new Random();
int attackValue = 0;
int winner = 0;

do
{
    attackValue = attack.Next(1, 10);
    monster = monster - attackValue;
    Console.WriteLine("Monster has" + monster + "hp and lost " + attackValue + "this turn");

    if (monster <= -1)
    {
         monster = 0;
        winner = 1;
        Console.WriteLine("The hero won!");

    }

    
   
     if(monster > 0)
    {
        attackValue = attack.Next(1, 10);
        hero = hero - attackValue;
        Console.WriteLine("Hero has" + hero + "hp and lost " + attackValue + "this turn");

    }

    if (hero <= -1)
    {

        hero = 0;
        winner = 1;
        Console.WriteLine("The monser won :(");
    }

} while (winner == 0);