int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = 0;
float result3 = 0;

// Your code here to set result

value1 = 12;
value2 = 6.2m;
value3 = 4.3f;


result1 = value1 / (int)value2;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result
value1 = 12;
value2 = 6.2m;
value3 = 4.3f;

decimal result2 = value2 / (decimal)value3;

 


Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3

value1 = 12;
value2 = 6.2m;
value3 = 4.3f;

result3 = value3 / value1;
result3 = (float)result3;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
