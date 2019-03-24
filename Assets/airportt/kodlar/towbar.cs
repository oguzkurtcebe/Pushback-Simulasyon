using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towbar : MonoBehaviour {
	public WheelCollider sol,sag,solD,sagD;
	public float tgucu, tacisi;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ayar ();
	}

	void ayar(){
		tgucu=GameObject.Find ("pushback").GetComponent<arac> ().Guc;
		tacisi=GameObject.Find ("pushback").GetComponent<arac> ().donmeacisiSag;

		sol.motorTorque = -tgucu/2;
		sag.motorTorque = -tgucu/2;

		solD.steerAngle = tacisi;
		sagD.motorTorque = tacisi;
	}
}
