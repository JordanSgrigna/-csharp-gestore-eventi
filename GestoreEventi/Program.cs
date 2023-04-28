using System.Diagnostics.Tracing;
using GestoreEventi;

/*
//MILESTONE 2 
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
*/

//MILESTONE 4
Console.Write("Inserisci il nome del programma eventi: ");
string userNameChosenForScheduler = Console.ReadLine();

Console.Write("Quanti eventi vuoi aggiungere? ");
int userNumberOfEvents = int.Parse(Console.ReadLine());

Console.WriteLine("");

ScheduleEvents Scheduler1 = new ScheduleEvents(userNameChosenForScheduler);


while (Scheduler1.GetListOfEvents().Count < userNumberOfEvents)
{	
		Console.Write("Inserisci il nome dell'evento: ");
		string userEventTitle = Console.ReadLine();

		Console.Write("Inserisci la data dell'evento (gg/mm/aaaa): ");
		DateTime userEventDate = DateTime.Parse(Console.ReadLine());

		Console.Write("Inserisci il numero massimo di posti disponibili: ");
		int userMaxNumberOfPeopleInEvent = int.Parse(Console.ReadLine());
	try 
	{
		Event Event = new Event(userEventTitle, userEventDate, userMaxNumberOfPeopleInEvent);

		Scheduler1.AddEventToEventList(Event);
	}
	catch (Exception e)
	{
		Console.WriteLine(e.ToString());
	}

	Console.WriteLine("");
}

Console.WriteLine(Scheduler1.ToString());

Console.Write("Inserisci una data per vedere quali eventi ci sono in quel giorno (dd/mm/yyyy): ");
DateTime userDateChosen = DateTime.Parse(Console.ReadLine());

List<Event> EventsWithSameDate = Scheduler1.GetListOfEventWithSameDate(userDateChosen);
Console.WriteLine(ScheduleEvents.ListInString(EventsWithSameDate));

Scheduler1.EmptyListOfEvents();
Console.WriteLine(Scheduler1.ToString());










