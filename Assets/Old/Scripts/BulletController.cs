using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	float bullet_force = 1000f;

	void Start () {
		GetComponent<Rigidbody>().AddForce(bullet_force * transform.forward);
		GetComponent<Rigidbody> ().mass = 0;
	}
}
