﻿public class Erlenmeyer : InteractiveObject {

	public string onLookSpeechId;
	private Speech onLookSpeech;

	public override void OnLook() {
		PlayerCharacter playerCharacter = Game.GetPlayerCharacter();
		playerCharacter.Look(transform.position);
		playerCharacter.Say(onLookSpeech);
	}

	public override void Start() {
		base.Start();
		onLookSpeech = LanguageManager.GetSpeech(onLookSpeechId);
	}

}