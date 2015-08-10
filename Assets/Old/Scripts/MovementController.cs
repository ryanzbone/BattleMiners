using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

	public float force = 50f;
	public float turnSpeed = 50f;
	public int player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (player == 1)
			PlayerOneInput ();
		else
			PlayerTwoInput ();
	}

	void PlayerOneInput() {
		if (Input.GetKey (KeyCode.UpArrow))
			GetComponent<Rigidbody> ().AddForce (transform.forward * force);
		if (Input.GetKey (KeyCode.DownArrow))
			GetComponent<Rigidbody> ().AddForce (transform.forward * -force);
	}

	void PlayerTwoInput() {
		if (Input.GetKey (KeyCode.UpArrow))
			GetComponent<Rigidbody> ().AddForce (transform.forward * force);
		if (Input.GetKey (KeyCode.DownArrow))
			GetComponent<Rigidbody> ().AddForce (transform.forward * -force);
	}
}
