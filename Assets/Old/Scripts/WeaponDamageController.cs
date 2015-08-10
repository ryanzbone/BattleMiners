using UnityEngine;
using System.Collections;

public class WeaponDamageController : MonoBehaviour {

	public int Damage;

	void OnCollisionEnter(Collision collision) 
	{
		if(collision.gameObject.GetComponent<HealthController>())
		{	
			Debug.Log("Hit with " + collision.gameObject.name);
			collision.gameObject.GetComponent<HealthController>().TakeDamage(Damage);
		}
		GameObject.Destroy(gameObject);
	}
}