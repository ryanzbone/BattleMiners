using UnityEngine;
using System.Collections;

public class TargetCollider : MonoBehaviour {

	void Update () {
		if(Input.GetKeyDown(KeyCode.R))
			gameObject.SetActive(true);
	}

}
