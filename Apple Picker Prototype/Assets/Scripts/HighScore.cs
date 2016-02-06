using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
	static public int score = 1000;

	void Awake() {
		//If the ApplePickerHighScore alread exists, read it
		if (PlayerPrefs.HasKey ("ApplePickerHighScore")) {
			score = PlayerPrefs.GetInt ("ApplePickerHighScore");
		}
		//Assignthehigh score to ApplePickerHighScore
		PlayerPrefs.SetInt("ApplePickerHighscore", score);
	}
	
	// Update is called once per frame
	void Update () {
		Text gt = this.GetComponent<Text> ();
		gt.text = "High Score: " + score;

		//update ApplePickerHighScore in PlayerPrefs if neccessary
		if (score > PlayerPrefs.GetInt ("ApplePickerHighScore")) {
			PlayerPrefs.SetInt ("ApplePickerHighScore", score);
		}
	}
}
