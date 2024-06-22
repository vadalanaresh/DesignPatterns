// See https://aka.ms/new-console-template for more information
var singleton1 = new Singleton.Singleton();
singleton1.PrintMessage("My first message");
var singleton2 = new Singleton.Singleton();
singleton2.PrintMessage("My second message");
Console.Read();