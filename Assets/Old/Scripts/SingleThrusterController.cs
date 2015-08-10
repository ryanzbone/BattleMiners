using UnityEngine;
using System.Collections;

public class SingleThrusterController : MonoBehaviour {

	KeyCode key_code;

	public void Boost(float force) {
		GetComponent<Rigidbody>().AddForce(transform.forward * force);
	}
}
