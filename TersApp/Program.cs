// See https://aka.ms/new-console-template for more information

using System.Text.Json.Serialization;
using TersApp.Model;

Console.WriteLine("Hello, World!");

var greeter = new Greeter(Guid.NewGuid(), "Begin .NET act II", 200);

Console.WriteLine(greeter);