using UnityEngine;
using System.Collections;

public class LaserBoltController : MonoBehaviour {
	
	float bullet_force = 2000f;
	
	void Start () {
		GetComponent<Rigidbody>().AddForce(bullet_force * transform.forward);
	}
}
