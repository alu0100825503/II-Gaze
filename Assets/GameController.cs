using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public delegate void throwBallDelegate();
	public static event throwBallDelegate throwBallEvent;
	public GameObject Ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			throwBallEvent ();
		}
 	}
}
