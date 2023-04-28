using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
	public class ScheduleEvents
	{
		private string name;
		List<Event> ListOfEvents;

		//CONSTRUCTOR
		public ScheduleEvents(string name)
		{
			this.name = name;
			this.ListOfEvents = new List<Event>();
		}

		//GETTERS
		public string GetName()
		{
			return this.name;
		}

		public List<Event> GetListOfEvents()
		{
			return this.ListOfEvents;
		}

		//METHODS
		public static string ListInString(List<Event> listOfEvents)
		{
			string infoString = "";
			foreach (Event EventsToPrint in listOfEvents)
			{
				infoString = "-" + EventsToPrint.ToString() + "\n";
				infoString = "\n";
			}
			return infoString;
		}

		public void AddEventToEventList(Event eventToAdd)
		{
			this.ListOfEvents.Add(eventToAdd);
		}

		public List<Event> GetListOfEventWithSameDate(DateTime date)
		{
			List<Event> listOfEventsWithSameDate = new List<Event>();

			foreach(Event eventWithSameDate in this.ListOfEvents)
			{
				if (eventWithSameDate.GetEventDate() == date)
				{
					listOfEventsWithSameDate.Add(eventWithSameDate);
				}
			}

			return listOfEventsWithSameDate;
		}

		public int GetNumberOfEvents(List<Event> listOfEvents)
		{
			return listOfEvents.Count;
		}

		public void EmptyListOfEvents()
		{
			this.ListOfEvents.Clear();
		}

		public override string ToString()
		{
			string infoString = "";
			foreach(Event eventInListToPrint  in this.ListOfEvents)
			{
				infoString = eventInListToPrint.GetEventDate().ToString("dd/MM/yyyy") + "-" + eventInListToPrint.GetEventTitle() + "\n";
			}

			return infoString;
			
		}


	}
}
