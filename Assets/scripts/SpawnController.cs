using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnController : MonoBehaviour {
	
	private float currentSpawnDelay;

	public GameObject blockPrefab;
	public float spawnDelay;
	public float blockSpeed;
	public float maxHeight;
	public float minHeight;
	public float maxWidth;
	public float minWidth;

	// Use this for initialization
	void Start () {
		this.currentSpawnDelay = 0;
	}
	
	// Update is called once per frame
	void Update () {
		spawnBlockListener ();
	}

	private void spawnBlockListener() {
		this.currentSpawnDelay += Time.deltaTime;
		if (this.currentSpawnDelay > this.spawnDelay) {
			this.currentSpawnDelay = 0;
			createBlock();
		}
	}

	private void createBlock() {
		float randomicPosition = ((Random.Range (minHeight, maxHeight)) >= ((minHeight + maxHeight)/2)) ? this.minHeight : this.maxHeight;
		Vector3 position = new Vector3(this.maxWidth, randomicPosition, transform.position.z-1);
		GameObject b = Instantiate (this.blockPrefab, position, this.blockPrefab.transform.rotation) as GameObject;
		b.SetActive (true);
		(b.GetComponent (typeof(BlockController)) as BlockController).Speed = this.blockSpeed;
	}

}
