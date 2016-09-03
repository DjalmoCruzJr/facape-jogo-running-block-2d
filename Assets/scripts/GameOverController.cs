using UnityEngine;
using System.Collections;

public class GameOverController : MonoBehaviour {

	public TextMesh score;
	public TextMesh record;

	// Use this for initialization
	void Start () {
		int recordScore  = PlayerPrefs.GetInt ("RecordScore");
		int recordlevel  = PlayerPrefs.GetInt ("RecordLevel");
		int playerScore  = PlayerPrefs.GetInt ("PlayerScore");
		int playerLevel  = PlayerPrefs.GetInt ("PlayerLevel");

		if (playerScore > recordScore) {
			PlayerPrefs.SetInt("RecordScore", playerScore);
			PlayerPrefs.SetInt("RecordLevel", playerLevel);
			this.record.text = "New Record: " + playerScore +" (level "+ playerLevel +")";
			this.score.text = "";
		} else if (recordScore != 0) {
			this.record.text = "Record: "+ recordScore  +" (level "+ recordlevel +")";
			this.score.text  = "You: "+ playerScore  +" (level "+ playerLevel +")";
		} else {
			this.record.text = "";
			this.score.text  = "";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Application.LoadLevel("GamePlay");
		} else if(Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}
	}


}
