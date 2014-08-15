﻿using System.Collections.Generic;
using UnityEngine;

public class SerializableDictionary<K, V, T> where T : SerializableDictionaryEntry<K, V> {

	public T[] Entries;

	private Dictionary<K, V> dictionary;
	
	public V this[K key] {
		get {
			if (dictionary == null)
				Initialize();

			return dictionary[key];
		}

		set {
			if (dictionary == null)
				Initialize();

			dictionary[key] = value;
		}
	}

	private void Initialize() {
		// Initializes the dictionary
		dictionary = new Dictionary<K, V>(Entries.Length);

		// Fills the dictionary
		foreach (T entry in Entries)
			dictionary.Add(entry.Key, entry.Value);
	}

}
