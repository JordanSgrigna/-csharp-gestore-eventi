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
		public Event(string eventTitle, DateTime eventDate, int maxNumberOfPeopleInEvent, int numberOfReservedSeats = 0)
		{
			this.eventTitle = eventTitle;

			if (eventDate > DateTime.Now)
			{
				this.eventDate = eventDate;
			}
			else
			{
				throw new Exception("Non puoi creare un evento nel passato!");
			}

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
				throw new Exception("Non puoi mettere una data nel passato!");
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
			if (reservationsToCancel < 0)
			{
				throw new Exception("Non puoi disdire posti negativi");
			}
			else if ((reservationsToCancel < this.numberOfReservedSeats))
			{
				throw new Exception("Non puoi disdire più posti di quanti ne siano stati prenotati");
			}
			else if((numberOfReservedSeats - reservationsToCancel > numberOfReservedSeats) && (eventDate < DateTime.Now))
			{
				throw new Exception("Non puoi disdire posti per questo evento");
			}
			else
			{
				this.numberOfReservedSeats -= reservationsToCancel;
			}
		}

		public override string ToString()
		{
			string eventInfo = $"{this.eventTitle} - {this.eventDate.ToString("dd/MM/yyyy")}";
			return eventInfo;
			
		}


	}
}
