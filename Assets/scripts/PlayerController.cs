using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private int score;

	public float movimentRate;
	public float maxWidth;
	public float minWidth;
	public float maxHeight;
	public float minHeight;	
	public float speed;

	// Use this for initialization
	void start() {
		this.score = 0;
	}

	// Update is called once per frame
	void Update () {
		movimentListener ();
	}

	private void movimentListener() {
		// Movimenta o player para CIMA
		if (Input.GetKey (KeyCode.W) && this.transform.position.y < maxHeight) {
			this.transform.Translate(0, (movimentRate * speed * Time.deltaTime), 0);
		}
		// Movimenta o player para BAIXO
		if(Input.GetKey (KeyCode.S) && this.transform.position.y > minHeight) {
			this.transform.Translate(0, -(movimentRate * speed * Time.deltaTime), 0);
		}
		// Movimenta o player para a DIREITA
		if(Input.GetKey(KeyCode.D) && this.transform.position.x < maxWidth) {
			this.transform.Translate((movimentRate * speed * Time.deltaTime), 0, 0);
		}
		// Movimenta o player para a ESQUERDA
		if(Input.GetKey(KeyCode.A) && this.transform.position.x > minWidth) {
			this.transform.Translate(-(movimentRate * speed * Time.deltaTime), 0, 0);
		}                                                                          
	}

	public int Score {
		get { return this.score; }
		set { this.score = value; }
	}

}