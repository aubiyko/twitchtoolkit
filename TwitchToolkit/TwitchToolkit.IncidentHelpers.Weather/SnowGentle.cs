using System.Collections.Generic;
using RimWorld;
using TwitchToolkit.Store;
using Verse;

namespace TwitchToolkit.IncidentHelpers.Weather
{
	public class SnowGentle : IncidentHelper
	{
		private Map target = (Map) null;
		private WeatherDef weather = (WeatherDef) null;

		public override bool IsPossible()
		{
			this.weather = DefDatabase<WeatherDef>.GetNamed(nameof (SnowGentle));
			List<Map> maps = Current.Game.Maps;
			maps.Shuffle<Map>();
			foreach (Map map in maps)
			{
				if (map.weatherManager.curWeather != this.weather)
				{
					this.target = map;
					return true;
				}
			}
			return false;
		}

		public override void TryExecute() => Helper.Weather((string) "TwitchStoriesDescription33".Translate(), this.weather, LetterDefOf.PositiveEvent);
	}
}
