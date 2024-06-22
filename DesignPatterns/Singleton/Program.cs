// See https://aka.ms/new-console-template for more information
var singleton1 = Singleton.Singleton.GetInstance;
singleton1.PrintMessage("My first message");
var singleton2 = Singleton.Singleton.GetInstance;
singleton2.PrintMessage("My second message");
Console.Read();