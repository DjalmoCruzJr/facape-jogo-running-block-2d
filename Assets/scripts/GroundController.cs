using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {
	
	private Material currentMaterial;
	private float offset;
	
	public float speed;

	// Use this for initialization
	void Start () {
		this.currentMaterial = this.renderer.material;
	}
	
	// Update is called once per frame
	void Update () {
		offset += 0.001f;
		this.currentMaterial.SetTextureOffset ("_MainTex", new Vector2 (this.offset * this.speed,0 ));
	}
}
