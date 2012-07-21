using System;
using System.Collections.Generic;
using MonoTouch.Foundation;

namespace MonoTouch
{
	public static class LocalizedCurrentLocation
	{
		public static string CurrentLocationStringForCurrentLanguage()
		{
			Dictionary<string, string> localizedStringDictionary = new Dictionary<string, string>();
			localizedStringDictionary.Add(@"nl", @"Huidige locatie");
			localizedStringDictionary.Add(@"en", @"Current Location");
			localizedStringDictionary.Add(@"fr", @"Lieu actuel");
			localizedStringDictionary.Add(@"de", @"Aktueller Ort");
			localizedStringDictionary.Add(@"it", @"Posizione attuale");
			localizedStringDictionary.Add(@"ja", @"???");
			localizedStringDictionary.Add(@"es", @"Ubicación actual");
			localizedStringDictionary.Add(@"ar", @"?????? ??????");
			localizedStringDictionary.Add(@"ca", @"Ubicació actual");
			localizedStringDictionary.Add(@"cs", @"Soucasná poloha");
			localizedStringDictionary.Add(@"da", @"Aktuel lokalitet");
			localizedStringDictionary.Add(@"el", @"??????sa t?p??es?a");
			localizedStringDictionary.Add(@"en-GB", @"Current Location");
			localizedStringDictionary.Add(@"fi", @"Nykyinen sijainti");
			localizedStringDictionary.Add(@"he", @"????? ?????");
			localizedStringDictionary.Add(@"hr", @"Trenutna lokacija");
			localizedStringDictionary.Add(@"hu", @"Jelenlegi helyszín");
			localizedStringDictionary.Add(@"id", @"Lokasi Sekarang");
			localizedStringDictionary.Add(@"ko", @"?? ??");
			localizedStringDictionary.Add(@"ms", @"Lokasi Semasa");
			localizedStringDictionary.Add(@"no", @"Nåværende plassering");
			localizedStringDictionary.Add(@"pl", @"Biezace polozenie");
			localizedStringDictionary.Add(@"pt", @"Localização Atual");
			localizedStringDictionary.Add(@"pt-PT", @"Localização actual");
			localizedStringDictionary.Add(@"ro", @"Loc actual");
			localizedStringDictionary.Add(@"ru", @"??????? ??????????");
			localizedStringDictionary.Add(@"sk", @"Aktuálna poloha");
			localizedStringDictionary.Add(@"sv", @"Nuvarande plats");
			localizedStringDictionary.Add(@"th", @"???????????????");
			localizedStringDictionary.Add(@"tr", @"Su Anki Yer");
			localizedStringDictionary.Add(@"uk", @"??????? ?????");
			localizedStringDictionary.Add(@"vi", @"V? trí Hi?n t?i");
			localizedStringDictionary.Add(@"zh-CN", @"????");
			localizedStringDictionary.Add(@"zh-TW", @"????");

			string localizedString = "Current Location";

		    if (localizedStringDictionary.ContainsKey(NSLocale.CurrentLocale.LanguageCode))
			{
				localizedString = localizedStringDictionary[NSLocale.CurrentLocale.LanguageCode];
		    }
			
    		return localizedString;
		}
	}
}