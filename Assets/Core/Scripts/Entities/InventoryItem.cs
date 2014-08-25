﻿using UnityEngine;

public class InventoryItem : MonoBehaviour {

	public GameImageParameters ImageParameters;

	public void Awake() {
		if (ImageParameters.SortingLayer.Length == 0)
			ImageParameters.SortingLayer = Parameters.InventoryItemImageSortingLayer;

		// Hides the inventory item initially
		Hide();
	}

	public void Hide() {
		gameObject.SetActive(false);
	}
	
	public void Show() {
		gameObject.SetActive(true);
	}

}
