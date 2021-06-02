#load "Scripts/Module.csx" // Contains the Addition method
#load "Scripts/Message.csx" // Contains a message in Console.WriteLine

Console.WriteLine("Hello from Test.csx");

var result1 = Addition(2,2);
Console.WriteLine($"Result of the 1st addition: {result1}");

var result2 = Addition(4, 4);
Console.WriteLine($"Result of the 1st addition: {result2}");

