// See https://aka.ms/new-console-template for more information
using ITransition.ELearning.DataAccessLayer;

Console.WriteLine("Hello, World!");

TestDataLayer td=new TestDataLayer();
await td.TestConnection();
