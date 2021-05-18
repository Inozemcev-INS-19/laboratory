using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21 {
				public class ShopProvider {
								private Magazin flight;

								public ShopProvider(Magazin f) {
												flight = f;
								}

								public string Product
								{
												get => flight.Product;
												set {
																flight.Product = value;
												}
								}

								public float Count
								{
												get => flight.Count;
												set {
																flight.Count = value;
												}
								}

								public float Amount {
												get => flight.Amount;
												set {
																flight.Amount = value;
												}
								}

								public string Shop {
												get => flight.Shop;
												set {
																flight.Shop = value;
												}
								}


								public string FlightInfo {
												get => $"{flight.Product} -> {flight.Count}. {flight.Amount}, {flight.Shop}";
								}
				}
}
