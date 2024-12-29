// dichiaro uno stack di stringhe
var stack = new Stack<string>(new[] { "Ciao", "Mondo", "Come", "Stai" });

// tolgo l'ultimo elemento inserito
stack.Pop();

// stampo lo stack aggiornato
Console.WriteLine("Stack aggiornato:");

foreach (string item in stack)
{
    Console.WriteLine(item);
}