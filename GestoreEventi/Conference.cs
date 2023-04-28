using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
	public class Conference : Event
	{
		//ATTRIBUTES
		private string speaker;
		private double price;

		//CONSTRUCTOR
		public Conference(string speaker, double price, string eventTitle, DateTime eventDate, int maxNumberOfPeopleInEvent, int numberOfReservedSeats = 0) : base(eventTitle, eventDate, maxNumberOfPeopleInEvent)
		{
			this.speaker = speaker;
			this.price = price;
		}

		//GETTERS
		public string GetSpeaker()
		{
			return speaker;
		}

		public double GetPrice()
		{
			return price;
		}

		//METHODS
		public string GetFormattedPrice()
		{
			string formattedPrice = this.price.ToString("0.00");
			return formattedPrice;
		}


		public override string ToString()
		{
			string eventInfo = $"{GetEventTitle()} - {GetEventDate().ToString("dd/MM/yyyy")} - {this.speaker} - {GetFormattedPrice()}";
			return eventInfo;
		}

	}
}
