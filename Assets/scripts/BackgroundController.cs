using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	private Material currentMaterial;
	public float speed;
	private float offset;
	
	// Use this for initialization
	void Start () {
		this.currentMaterial = this.renderer.material;
	}
	
	// Update is called once per frame
	void Update () {
		this.offset += 0.001f;
		this.currentMaterial.SetTextureOffset ("_MainTex", new Vector2 (offset * speed,0 ));
	}
}
