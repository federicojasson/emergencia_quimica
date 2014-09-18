﻿using System.Collections;

namespace SaguFramework {
	
	public sealed class MainMenuLoader : Loader {
		
		protected override IEnumerator LoadSceneCoroutine() {
			SoundPlayer.StopAllSounds();
			SoundPlayer.PlayMainMenuSong();
			MenuHandler.OpenMainMenu();
			yield return StartCoroutine(GraphicHandler.FadeIn(Parameters.GetMainMenuLoaderParameters().FadeIn));
		}
		
		protected override IEnumerator UnloadSceneCoroutine() {
			yield return StartCoroutine(GraphicHandler.FadeOut(Parameters.GetMainMenuLoaderParameters().FadeOut));
			SoundPlayer.StopAllSounds();
			SoundPlayer.PlayPlaylist();
		}

	}
	
}
