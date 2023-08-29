// See https://aka.ms/new-console-template for more information
using LSP;

//Console.WriteLine("Hello, World!");

IFileRead accessData = new AdminFileUser();
accessData.ReadFile();

IFileWrite accessDat = new AdminFileUser();
accessDat.WriteFile();


IFileRead accessDataRead = new Guest();
accessDataRead.ReadFile();

Console.Read();