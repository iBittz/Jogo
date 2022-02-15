using Jogo.src.Entities;
using static System.Console;
Knight Arus = new Knight("Arus", 42, "Knight");
Wizard Ramza = new Wizard("Ramza", 42, "Mage");

WriteLine(Arus.Attack());
WriteLine(Ramza.Attack(10, Arus));
WriteLine(Arus);