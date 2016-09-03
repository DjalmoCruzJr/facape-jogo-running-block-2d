using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private PlayerController player;
	private SpawnController spawner;
	private bool isLevelChangeEnable;
	private int currentLevel;

	public TextMesh score; 
	public TextMesh level; 
	public float minSpawnDelay;
	public float spawnDelayRate;
	public int changeLevelPoints;
	public float maxBlockSpeed;
	public float blockSpeedRate;

	// Use this for initialization
	void Start () {
		this.player = FindObjectOfType (typeof(PlayerController)) as PlayerController;
		this.spawner = FindObjectOfType (typeof(SpawnController)) as SpawnController;
		this.currentLevel  = 1;
		this.minSpawnDelay = this.minSpawnDelay > 0 ? this.minSpawnDelay : 1f;
		this.spawnDelayRate = this.spawnDelayRate > 0 ? this.spawnDelayRate : .2f;
		this.isLevelChangeEnable = true;
	}
	
	// Update is called once per frame
	void Update () {
		onChangeLevelListener ();
		onUpdateHUDListener ();
	}

	private void onUpdateHUDListener() {
		this.score.text = ""+ this.player.Score;
		this.level.text = ""+ this.currentLevel;
	}

	private void onChangeLevelListener() {
		if (this.player.Score > 0 && this.player.Score % this.changeLevelPoints == 0) {
			if(this.isLevelChangeEnable) {
				this.currentLevel++;
				this.isLevelChangeEnable = false;
				updateSpawnerLevel();
			}
		} else {
			this.isLevelChangeEnable = true;
		}
	}

	private void updateSpawnerLevel() {
		this.spawner.blockSpeed = ((this.spawner.blockSpeed + this.blockSpeedRate) > this.maxBlockSpeed) ? this.maxBlockSpeed : (this.spawner.blockSpeed + this.blockSpeedRate);
		this.spawner.spawnDelay = ((this.spawner.spawnDelay - this.spawnDelayRate) < this.minSpawnDelay) ? this.minSpawnDelay : (this.spawner.spawnDelay - this.spawnDelayRate); 
	}

	public int Level {
		get{return this.currentLevel;}
		set{this.currentLevel = value;}
	}

}
