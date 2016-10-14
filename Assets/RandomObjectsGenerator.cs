using UnityEngine;
using System.Collections;

public class RandomObjectsGenerator : MonoBehaviour {
	private const int NUM_RND_OBJECTS = 50;
	private const int OBJECTS_HEIGHT = 7;
	private const int RND_LIMIT = 100;

	public GameObject randomObject1;
	public GameObject randomObject2;
	public GameObject randomObject3;

	void Start () {
		int x1, x2, x3;
		int y1 = OBJECTS_HEIGHT, y2 = OBJECTS_HEIGHT, y3 = OBJECTS_HEIGHT;
		int z1, z2, z3;

		// Generating objects randomly
		for (int i = 0; i < NUM_RND_OBJECTS; i++) {
			x1 = Random.Range (-RND_LIMIT, RND_LIMIT);
			x2 = Random.Range (-RND_LIMIT, RND_LIMIT);
			x3 = Random.Range (-RND_LIMIT, RND_LIMIT);
			z1 = Random.Range (-RND_LIMIT, RND_LIMIT);
			z2 = Random.Range (-RND_LIMIT, RND_LIMIT);
			z3 = Random.Range (-RND_LIMIT, RND_LIMIT);

			// Creating the objects
			GameObject newObj1 = (GameObject) Object.Instantiate (randomObject1, new Vector3 (x1, y1, z1), Quaternion.identity);
			GameObject newObj2 = (GameObject) Object.Instantiate (randomObject2, new Vector3 (x2, y2, z2), Quaternion.identity);
			GameObject newObj3 = (GameObject) Object.Instantiate (randomObject3, new Vector3 (x3, y3, z3), Quaternion.identity);

			newObj1.transform.localScale = new Vector3 (3, 3, 3);
			newObj2.transform.localScale = new Vector3 (3, 3, 3);
			newObj3.transform.localScale = new Vector3 (3, 3, 3);

			// Adding a script to the new objects
			newObj1.AddComponent <FiguresBehaviour>();
			newObj2.AddComponent <FiguresBehaviour>();
			newObj3.AddComponent <FiguresBehaviour>();

			// Adding a Renderer component to the new objects
			//newObj1.AddComponent <Renderer>();
			//newObj2.AddComponent <Renderer>();
			//newObj3.AddComponent <Renderer>();

			newObj1.tag = "newObj1";
			newObj2.tag = "newObj2";
			newObj3.tag = "newObj3";
		}
	}
	
	void Update () {
			
	}
}
