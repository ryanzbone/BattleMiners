using UnityEngine;
using System.Collections;

public class AsteroidController : MonoBehaviour {

	public GameObject AsteroidPart;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "bullet") {
			DecrementSize();
			SpawnSpaceGarbage(collision.transform.position);
		}
	}

	void DecrementSize() {
		transform.localScale = new Vector3 (transform.localScale.x - 1, transform.localScale.y - 1, transform.localScale.z - 1);
	}

	void SpawnSpaceGarbage(Vector3 position) {
		GameObject.Instantiate (AsteroidPart, position, Quaternion.identity);
		GameObject.Instantiate (AsteroidPart, position, Quaternion.identity);
		GameObject.Instantiate (AsteroidPart, position, Quaternion.identity);

	}
}
