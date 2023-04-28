using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
	public class Event
	{
		//ATTRIBUTES
		private string eventTitle;
		private DateTime eventDate;
		private int maxNumberOfPeopleInEvent;
		private int numberOfReservedSeats;

		//COSTRUTTORE
		public Event(string eventTitle, DateTime eventDate, int maxNumberOfPeopleInEvent, int numberOfReservedSeats)
		{
			this.eventTitle = eventTitle;
			this.eventDate = new DateTime();
			this.maxNumberOfPeopleInEvent = maxNumberOfPeopleInEvent;
			this.numberOfReservedSeats = numberOfReservedSeats;
		}

		//GETTERS
		public string GetEventTitle()
		{
			return this.eventTitle;
		}

		public DateTime GetEventDate()
		{
			return this.eventDate;
		}

		public int GetMaxNumberOfPeopleInEvent()
		{
			return this.maxNumberOfPeopleInEvent;
		}

		public int GetNumberOfReservedSeats()
		{
			return this.numberOfReservedSeats;
		}

		//SETTERS
		public void SetEventTitle(string newEventTitle)
		{
			this.eventTitle = newEventTitle;
		}

		public void SetEventDate(DateTime newEventDate)
		{
			if (newEventDate > DateTime.Now)
			{
				this.eventDate = newEventDate;
			}
			else
			{
				throw new Exception("Non puoi creare un evento nel passato!");
			}
		}

		//METHODS
		public void BookSeats(int seatsToBook)
		{
			if ((numberOfReservedSeats + seatsToBook < maxNumberOfPeopleInEvent) && (eventDate > DateTime.Now))
			{
				numberOfReservedSeats += seatsToBook;
			}
			else
			{
				throw new Exception("Non ci sono più posti disponibili");
			}
		}

		public void CancelReservations (int reservationsToCancel)
		{
			if ((numberOfReservedSeats - reservationsToCancel < numberOfReservedSeats) && (eventDate > DateTime.Now))
			{
				numberOfReservedSeats -= reservationsToCancel;
			}
			else
			{
				throw new Exception("Non ci sono più prenotazioni da disdire");
			}
		}

		public override string ToString()
		{
			string eventInfo = $"{this.eventTitle} - {this.eventDate.ToString("dd/MM/yyyy")}";
			return eventInfo;
			
		}


	}
}
