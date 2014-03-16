using System.Collections.Generic;

public static class LanguageManager {

	private static Dictionary<string, Speech> speeches;
	private static Dictionary<string, string> texts;

	static LanguageManager() {
		speeches = new Dictionary<string, Speech>();
		texts = new Dictionary<string, string>();
	}

	public static Speech GetSpeech(string id) {
		return speeches[id];
	}

	public static string GetText(string id) {
		return texts[id];
	}

	public static void LoadLanguage(string languageId) {
		// TODO: load from XML
		//Resources.Load(P.LANGUAGE_FILE_PATH(languageId));
		UnityEngine.Debug.Log("TODO: load language from XML: " + P.LANGUAGE_FILE_PATH(languageId));

		speeches.Clear();
		texts.Clear();

		// TODO
	}

}                                                                                                                                                                                                                                                                                                                                                                     
