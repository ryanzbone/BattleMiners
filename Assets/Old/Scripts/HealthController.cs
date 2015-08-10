using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {

	private int Health;
	public int MaxHealth;

	Renderer rend;

	// Use this for initialization
	void Start () {
		Health = MaxHealth;	
		rend = GetComponent<Renderer>();
	}

	void Update() {
		if (Health >= 3) {
			rend.material.color = Color.green;
		} else if (Health >= 2) {
			rend.material.color = Color.yellow;
		} else if (Health >= 1) {
			rend.material.color = Color.red;
		}

	}

	public void TakeDamage(int amount)
	{
		Health -= amount;

		if (Health <= 0)
			gameObject.SetActive (false);
	}
}
