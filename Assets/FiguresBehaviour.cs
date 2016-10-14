using UnityEngine;
using System.Collections;

public class FiguresBehaviour : MonoBehaviour { 
	private bool collided;

	void Start () {
		gameObject.AddComponent<Rigidbody> ();
		gameObject.GetComponent<Rigidbody> ().useGravity = false;
		collided = false;
	}

	void Update () {
		// Las frutas giran hasta que sean colisionadas
		if (!collided) {
			Vector3 aux = new Vector3 (0, 1, 0);
			gameObject.transform.Rotate (aux * 50 * Time.deltaTime);		
		}
	}
		
	Color getRndColor() {
		int rndColor = Random.Range (0, 5);

		switch (rndColor) {
		case 0:
			return Color.white;
		case 1: 
			return Color.red; 
		case 2: 
			return Color.blue;
		case 3: 
			return Color.yellow;
		case 4: 
			return Color.green;
		case 5: 
			return Color.grey;
		default: 
			return Color.clear;
		}
	}

	// Cuando se colisiona con un tipo de objeto, todos los objetos de ese tipo cambian
	// de color aleatoriamente
	void OnCollisionEnter() {
		string collidedFigureTag = gameObject.tag;
		GameObject[] figuresWithSameTag = GameObject.FindGameObjectsWithTag (collidedFigureTag);

		for (int i = 0; i < figuresWithSameTag.Length; i++) {
			figuresWithSameTag [i].GetComponent<Renderer> ().material.color = getRndColor ();
		}

		collided = true;
	}
}
