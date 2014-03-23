using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

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
		speeches.Clear();
		texts.Clear();

		TextAsset textAsset = (TextAsset) Resources.Load(P.LANGUAGE_FILE_PATH(languageId), typeof(TextAsset));
		XElement root = XDocument.Parse(textAsset.text).Root;

		// TODO: maybe use constants for node names
		foreach (XElement node in root.Elements())
			switch (node.Name.LocalName) {
				case "speech" : {
					string id = node.Attribute("id").Value.Trim();
					string text = node.Element("text").Value.Trim();
					AudioClip audio = (AudioClip) Resources.Load(P.LANGUAGE_AUDIO_PATH(languageId, node.Element("audio").Value.Trim()), typeof(AudioClip));
					Speech speech = new Speech(text, audio);
					speeches.Add(id, speech);
					break;
				}
				
				case "text" : {
					string id = node.Attribute("id").Value.Trim();
					string text = node.Value.Trim();
					texts.Add(id, text);
					break;
				}
			}
	}

}                                                                                                                                                                                                                                                                                                                                                                     
