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
			localizedStringDictionary.Add(@"ja", @"現在地");
			localizedStringDictionary.Add(@"es", @"Ubicación actual");
			localizedStringDictionary.Add(@"ar", @"الموقع الحالي");
			localizedStringDictionary.Add(@"ca", @"Ubicació actual");
			localizedStringDictionary.Add(@"cs", @"Současná poloha");
			localizedStringDictionary.Add(@"da", @"Aktuel lokalitet");
			localizedStringDictionary.Add(@"el", @"Τρέχουσα τοποθεσία");
			localizedStringDictionary.Add(@"en-GB", @"Current Location");
			localizedStringDictionary.Add(@"fi", @"Nykyinen sijainti");
			localizedStringDictionary.Add(@"he", @"מיקום נוכחי");
			localizedStringDictionary.Add(@"hr", @"Trenutna lokacija");
			localizedStringDictionary.Add(@"hu", @"Jelenlegi helyszín");
			localizedStringDictionary.Add(@"id", @"Lokasi Sekarang");
			localizedStringDictionary.Add(@"ko", @"현재 위치");
			localizedStringDictionary.Add(@"ms", @"Lokasi Semasa");
			localizedStringDictionary.Add(@"no", @"Nåværende plassering");
			localizedStringDictionary.Add(@"pl", @"Bieżące położenie");
			localizedStringDictionary.Add(@"pt", @"Localização Atual");
			localizedStringDictionary.Add(@"pt-PT", @"Localização actual");
			localizedStringDictionary.Add(@"ro", @"Loc actual");
			localizedStringDictionary.Add(@"ru", @"Текущее размещение");
			localizedStringDictionary.Add(@"sk", @"Aktuálna poloha");
			localizedStringDictionary.Add(@"sv", @"Nuvarande plats");
			localizedStringDictionary.Add(@"th", @"ที่ตั้งปัจจุบัน");
			localizedStringDictionary.Add(@"tr", @"Şu Anki Yer");
			localizedStringDictionary.Add(@"uk", @"Поточне місце");
			localizedStringDictionary.Add(@"vi", @"Vị trí Hiện tại");
			localizedStringDictionary.Add(@"zh-CN", @"当前位置");
			localizedStringDictionary.Add(@"zh-TW", @"目前位置");

			string localizedString = "Current Location";

		    if (localizedStringDictionary.ContainsKey(NSLocale.CurrentLocale.LanguageCode))
			{
				localizedString = localizedStringDictionary[NSLocale.CurrentLocale.LanguageCode];
		    }
    
    		return localizedString;
		}
	}
}

