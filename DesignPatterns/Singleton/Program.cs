// See https://aka.ms/new-console-template for more information
var singleton1 = Singleton.Singleton.GetInstance;
singleton1.PrintMessage("My first message");
var singleton2 = Singleton.Singleton.GetInstance;
singleton2.PrintMessage("My second message");

var singleton3 = Singleton.Singleton.GetInstance;
singleton3.PrintMessage("My second message");

var singleton4 = Singleton.Singleton.GetInstance;
singleton4.PrintMessage("My second message");

var singleton5 = Singleton.Singleton.GetInstance;
singleton5.PrintMessage("My second message");
Console.Read();