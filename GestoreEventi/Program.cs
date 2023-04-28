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

Event Event1 = new Event(userEventTitle, userEventDate, userMaxNumberOfPeopleInEvent, userNumberOfReservedSeats);

bool userWantsToStop = false;


while (!userWantsToStop)
{
	Console.Write("Vuoi disdire dei posti (si/no)? ");
	string userYesOrNo = Console.ReadLine().ToLower();

	if (userYesOrNo == "si")
	{
		userWantsToStop = false;
		Console.Write("Quanti posti vuoi disdire? ");
		int reservationsToCancel = int.Parse(Console.ReadLine());
		Event1.CancelReservations(reservationsToCancel);

		Console.WriteLine();
		Console.WriteLine("Il numero di posti disponibili è: " + Event1.GetMaxNumberOfPeopleInEvent());
		Console.WriteLine("Il numero di posti prenotati è: " + Event1.GetNumberOfReservedSeats());
		Console.WriteLine();
	}
	else if (userYesOrNo == "no")
	{
		Console.WriteLine("Ok va bene!");
		userWantsToStop = true;
	}



}
