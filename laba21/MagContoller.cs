using System;
using System.Collections.Generic;
using System.Linq;

namespace lab21 {
	public class MagContoller {
		private List<ShopProvider> flights = new List<ShopProvider>();

		public MagContoller() {
			List<Magazin> _flights = MagRepository.GetAllFlights();
			flights = _flights.ConvertAll(f => new ShopProvider(f));
		}

		public List<ShopProvider> AllFlights {
			get => flights;
		}

		public int ByBusAmount {
			get => flights.FindAll(f => f.Shop == "Магнит").Count;
		}

		public float ByPlannesPrices {
			get => flights
			.FindAll(f => f.Shop == "ТЦ Карандаш")
			.Aggregate(0f, (acc, f) => acc + f.Count);
		}

		public float MaxFlightPrice {
			get => flights.OrderByDescending(f => f.Count).First().Count;
		}
	}
}
