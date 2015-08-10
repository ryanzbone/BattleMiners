using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SymmetricMovementController : MonoBehaviour {

	SingleThrusterController t0, t1, t2, t3, t4, t5, t6, t7;
	List<GameObject> Forward, Reverse, Clockwise, CounterClockwise, Right, Left;
	public float force = 10f;

	// Use this for initialization
	void Start () {
		t0 = transform.Find ("Top/t0").gameObject.GetComponent<SingleThrusterController>();
		t1 = transform.Find ("Right/t1").gameObject.GetComponent<SingleThrusterController>();
		t2 = transform.Find ("Right/t2").gameObject.GetComponent<SingleThrusterController>();
		t3 = transform.Find ("Bottom/t3").gameObject.GetComponent<SingleThrusterController>();
		t4 = transform.Find ("Bottom/t4").gameObject.GetComponent<SingleThrusterController>();
		t5 = transform.Find ("Left/t5").gameObject.GetComponent<SingleThrusterController>();
		t6 = transform.Find ("Left/t6").gameObject.GetComponent<SingleThrusterController>();
		t7 = transform.Find ("Top/t7").gameObject.GetComponent<SingleThrusterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.O))
			t0.Boost (force);
		if (Input.GetKey (KeyCode.P))
			t1.Boost (force);
		if (Input.GetKey (KeyCode.Semicolon))
			t2.Boost (force);
		if (Input.GetKey (KeyCode.L))
			t3.Boost (force);
		if (Input.GetKey (KeyCode.S))
			t4.Boost (force);
		if (Input.GetKey (KeyCode.A))
			t5.Boost (force);
		if (Input.GetKey (KeyCode.Q))
			t6.Boost (force);
		if (Input.GetKey (KeyCode.W))
			t7.Boost (force);
	}
}
