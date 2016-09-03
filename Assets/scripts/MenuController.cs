using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public TextMesh record;

	// Use this for initialization
	void Start () {
		int recordScore = PlayerPrefs.GetInt ("RecordScore");
		int recordlevel = PlayerPrefs.GetInt ("RecordLevel");
		if (recordScore != 0) {
			this.record.text = "Record: "+ recordScore  +" (level "+ recordlevel +")";
		} else {
			this.record.text = "";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Application.LoadLevel("GamePlay");
		} else if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		} 
	}


}
