using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lab21 {
	public class MagRepository {
		private static char csvSeparator = '/';
		private static string sourceFilePath = @"/magazin.csv";

		public static List<Magazin> GetAllFlights() {
			try {
				List<Magazin> flights = new List<Magazin>();

				string[] fileData = File.ReadAllLines(sourceFilePath);

				foreach(string line in fileData) {
					string[] values = line.Split(csvSeparator);
					flights.Add(new Magazin() {
					Product = flights.Count.ToString(),
					Count = (float)Convert.ToDouble(values[0]),
					Amount = (float)Convert.ToDouble(values[1]),
					Shop = values[2],
					});
				}
				return flights;
			}
			catch(Exception) {
				return new List<Magazin>();
			}
		}

		public static void SaveAllFlights(List<Magazin> flights) {
			List<string> data = flights.ConvertAll(f => $"{f.Product}{csvSeparator}{f.Count}{csvSeparator}{f.Amount}{csvSeparator}{f.Shop}");
			File.Delete(sourceFilePath);
			File.WriteAllLines(sourceFilePath, data);
		}
	}
}
