using System.Collections;
using UnityEngine;

public class SplashScreenLoader : MonoBehaviour {
	
	public void Start() {
		StartCoroutine(LoadCoroutine());
	}

	private IEnumerator LoadCoroutine() {
		Timer timer = UtilityManager.CreateTimer();
		timer.RegisterStartTime();

		float fadeInSpeed = ConfigurationManager.SplashScreenCurtainFadeInSpeed;
		yield return StartCoroutine(GuiManager.CurtainFadeInCoroutine(fadeInSpeed));

		float minimumDelayTime = ConfigurationManager.SplashScreenMinimumDelayTime;
		yield return StartCoroutine(timer.WaitForAtLeastSecondsCoroutine(minimumDelayTime));

		float fadeOutSpeed = ConfigurationManager.SplashScreenCurtainFadeOutSpeed;
		yield return StartCoroutine(GuiManager.CurtainFadeOutCoroutine(fadeOutSpeed));

		StateManager.LoadCurrentRoom();
	}
	
}