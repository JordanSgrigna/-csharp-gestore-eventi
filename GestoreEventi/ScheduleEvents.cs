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
		public ScheduleEvents(string name, List<Event> listOfEvents)
		{
			this.name = name;
			this.ListOfEvents = new List<Event>;
		}

		//GETTERS
		public string GetName()
		{
			return this.name;
		}

		public List<Event> GetListOfEvent()
		{
			return this.ListOfEvents;
		}

		//METHODS
		public override string ToString()
		{
			foreach (Event EventToPrint in this.ListOfEvents)
			{
				return EventToPrint.ToString();
			}
		}

		public void AddEventToEventList(Event eventToAdd)
		{
			this.ListOfEvents.Add(eventToAdd);
		}


	}
}
