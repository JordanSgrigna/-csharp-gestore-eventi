using System.Diagnostics.Tracing;
using GestoreEventi;

Console.Write("Inserisci il nome dell'evento: ");
string userEventTitle = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (gg/mm/aaaa): ");
DateTime userEventDate = DateTime.Parse(Console.ReadLine());

Console.Write("Inserisci il numero massimo di posti disponibili: ");
int userMaxNumberOfPeopleInEvent = int.Parse(Console.ReadLine());

Console.Write("Quanti posti vuoi prenotare? ");
int userNumberOfReservedSeats = int.Parse(Console.ReadLine());

Event 
