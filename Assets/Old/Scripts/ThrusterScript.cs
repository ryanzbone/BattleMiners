﻿using UnityEngine;
using System.Collections;

public class ThrusterScript : MonoBehaviour {

	public float force = 50f;
	public bool right = true;
	KeyCode up, down;
	GameObject fps, bps;

	// Use this for initialization
	void Start () {
		fps = transform.Find("ForwardParticles").gameObject;
		bps = transform.Find("BackwardParticles").gameObject;

		if(right)
		{
			up = KeyCode.UpArrow;
			down = KeyCode.DownArrow;
		}
		else
		{
			up = KeyCode.W;
			down = KeyCode.S;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftShift)) {
			GetComponent<Rigidbody>().velocity = Vector3.zero;
			fps.SetActive(false);
			bps.SetActive(false);
		}
		if (Input.GetButton ("Cancel"))
			Debug.Log ("controler works");

//		if (Input.GetAxis("p1VerticalLeft") > 0) {
		if(Input.GetKey(up)) {
			GetComponent<Rigidbody>().AddForce(transform.forward * force);
			fps.SetActive(true);
			bps.SetActive(false);
		}
//	    if (Input.GetAxis("p1VerticalLeft") < 0)	 {
		if(Input.GetKey(down)) {
			GetComponent<Rigidbody>().AddForce(transform.forward * -force);
			fps.SetActive(false);
			bps.SetActive(true);
		}
		if(Input.GetKeyUp(up))
			fps.SetActive(false);
		if(Input.GetKeyUp (down))
			bps.SetActive(false);
	}
}
