using UnityEngine;
using System.Collections;

public class ScriptsContainer : MonoBehaviour {
	public GameObject Ball;

	void Start () {
		Cursor.visible = false;
		GameController.throwBallEvent += throwBall;
	}

	void Update () {
		
	}

	void throwBall() {
		GameObject camera = GameObject.Find ("Main Camera");
		GameObject newObject = (GameObject) Instantiate (Ball, camera.transform.position, camera.transform.rotation);
		newObject.GetComponent<Rigidbody> ().AddForce (camera.transform.forward * 5000);
		Destroy (newObject, 5);
	}

	void onDestroy() {
		GameController.throwBallEvent -= throwBall;
	}
}