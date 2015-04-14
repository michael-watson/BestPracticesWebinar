using System;
using System.Collections.Generic;
using System.Linq;

namespace BestPracticesWebinar_Exercise_1
{
	public class HopDatabases
	{
		private List<Hops> hops;

		public List<Hops> GetHops()
		{
			return hops;
		}

		public HopDatabases()
		{
			hops = new List<Hops> {
				new Hops {
					HopName = "Admiral",
					AALow = 11,
				},
				new Hops {
					HopName = "Ahtanum",
					AALow = 3.5,
				},
				new Hops {
					HopName = "Amarillo",
					AALow = 8,
				},
				new Hops {
					HopName = "Apollo",
					AALow = 18,
				},
				new Hops {
					HopName = "Aquila",
					AALow = 6,
				},
				new Hops {
					HopName = "Banner",
					AALow = 9,
				},
				new Hops {
					HopName = "Bramling Cross",
					AALow = 5,
				},
				new Hops {
					HopName = "Bravo",
					AALow = 14,
				},
				new Hops {
					HopName = "Brewers Gold",
					AALow = 6,
				},
				new Hops {
					HopName = "Bullion",
					AALow = 6.5,
				},
				new Hops {
					HopName = "Calypso",
					AALow = 10,
				},
				new Hops {
					HopName = "Cascade",
					AALow = 4,
				},
				new Hops {
					HopName = "Centennial",
					AALow = 9,
				},
				new Hops {
					HopName = "Challenger",
					AALow = 7,
				},
				new Hops {
					HopName = "Chinook",
					AALow = 11,
				},
				new Hops {
					HopName = "Citra",
					AALow = 10,
				},
				new Hops {
					HopName = "Cluster",
					AALow = 5.5,
				},
				new Hops {
					HopName = "Columbia",
					AALow = 12,
				},
				new Hops {
					HopName = "Columbus",
					AALow = 13,
				},
				new Hops {
					HopName = "Comet",
					AALow = 8,
				},
				new Hops {
					HopName = "Crystal",
					AALow = 3,
				},
				new Hops {
					HopName = "Delta",
					AALow = 6.5,
				},
				new Hops {
					HopName = "Eroica",
					AALow = 11,
				},
				new Hops {
					HopName = "First Gold",
					AALow = 6,
				},
				new Hops {
					HopName = "Fuggle",
					AALow = 4,
				},
				new Hops {
					HopName = "Galaxy",
					AALow = 11,
				},
				new Hops {
					HopName = "Galena",
					AALow = 10,
				},
				new Hops {
					HopName = "Glacier",
					AALow = 5,
				},
				new Hops {
					HopName = "Golding",
					AALow = 4,
				},
				new Hops {
					HopName = "Green Bullet",
					AALow = 9,
				},
				new Hops {
					HopName = "Hallertau-Domestic",
					AALow = 5,
				},
				new Hops {
					HopName = "Hallertau-German",
					AALow = 3.5,
				},
				new Hops {
					HopName = "Hallertau Hersbrucker",
					AALow = 3,
				},
				new Hops {
					HopName = "Hallertau Mittelfruh",
					AALow = 3,
				},
				new Hops {
					HopName = "Herald",
					AALow = 11,
				},
				new Hops {
					HopName = "Horizon",
					AALow = 12,
				},
				new Hops {
					HopName = "Huller",
					AALow = 4,
				},
				new Hops {
					HopName = "Kent Golding",
					AALow = 3,
				},
				new Hops {
					HopName = "Liberty",
					AALow = 3,
				},
				new Hops {
					HopName = "Lublin",
					AALow = 3,
				},
				new Hops {
					HopName = "Magnum",
					AALow = 12,
				},
				new Hops {
					HopName = "Millenium",
					AALow = 14,
				},
				new Hops {
					HopName = "Motueka",
					AALow = 6.5,
				},
				new Hops {
					HopName = "Mt. Hood",
					AALow = 5,
				},
				new Hops {
					HopName = "Nelson Sauvin",
					AALow = 12,
				},
				new Hops {
					HopName = "Newport",
					AALow = 10,
				},
				new Hops {
					HopName = "New Zealand Hallertauer",
					AALow = 8,
				},
				new Hops {
					HopName = "Northdown",
					AALow = 7,
				},
				new Hops {
					HopName = "Northern Brewer",
					AALow = 7,
				},
				new Hops {
					HopName = "Nugget",
					AALow = 11,
				},
				new Hops {
					HopName = "Olympic",
					AALow = 11,
				},
				new Hops {
					HopName = "Omega",
					AALow = 9,
				},
				new Hops {
					HopName = "Orion",
					AALow = 6,
				},
				new Hops {
					HopName = "Pacifica",
					AALow = 5,
				},
				new Hops {
					HopName = "Pacific Gem",
					AALow = 15,
				},
				new Hops {
					HopName = "Pacific Jade",
					AALow = 12,
				},
				new Hops {
					HopName = "Palisade",
					AALow = 6,
				},
				new Hops {
					HopName = "Perle",
					AALow = 7,
				},
				new Hops {
					HopName = "Phoenix",
					AALow = 10,
				},
				new Hops {
					HopName = "Pioneer",
					AALow = 8,
				},
				new Hops {
					HopName = "Pride of Ringwood",
					AALow = 7,
				},
				new Hops {
					HopName = "Progress",
					AALow = 5,
				},
				new Hops {
					HopName = "Riwaka",
					AALow = 4.5,
				},
				new Hops {
					HopName = "Saaz",
					AALow = 3,
				},
				new Hops {
					HopName = "Santiam",
					AALow = 5.5,
				},
				new Hops {
					HopName = "Saphir",
					AALow = 3,
				},
				new Hops {
					HopName = "Simcoe",
					AALow = 12,
				},
				new Hops {
					HopName = "Sladek",
					AALow = 9,
				},
				new Hops {
					HopName = "Sorachi Ace",
					AALow = 13,
				},
				new Hops {
					HopName = "Southern Cross",
					AALow = 12,
				},
				new Hops {
					HopName = "Spalter",
					AALow = 3,
				},
				new Hops {
					HopName = "Sterling",
					AALow = 6,
				},
				new Hops {
					HopName = "Sticklebract",
					AALow = 9,
				},
				new Hops {
					HopName = "Styrian Goldings",
					AALow = 4,
				},
				new Hops {
					HopName = "Summit",
					AALow = 17.5,
				},
				new Hops {
					HopName = "Sun",
					AALow = 15,
				},
				new Hops {
					HopName = "Super Alpha",
					AALow = 10,
				},
				new Hops {
					HopName = "Super Galena",
					AALow = 13,
				},
				new Hops {
					HopName = "Talisman",
					AALow = 7,
				},
				new Hops {
					HopName = "Target",
					AALow = 10,
				},
				new Hops {
					HopName = "Taurus",
					AALow = 12,
				},
				new Hops {
					HopName = "Tettnang",
					AALow = 4,
				},
				new Hops {
					HopName = "Tomahawk",
					AALow = 14,
				},
				new Hops {
					HopName = "Tradition",
					AALow = 10,
				},
				new Hops {
					HopName = "Ultra",
					AALow = 3,
				},
				new Hops {
					HopName = "Vanguard",
					AALow = 4,
				},
				new Hops {
					HopName = "Warrior",
					AALow = 14.5,
				},
				new Hops {
					HopName = "Willamette",
					AALow = 4,
				},
				new Hops {
					HopName = "Yeoman",
					AALow = 9,
				},
				new Hops {
					HopName = "Zeus",
					AALow = 14,
				},
			};
		}
	}
}