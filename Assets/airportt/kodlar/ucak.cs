using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucak : MonoBehaviour {
	public WheelCollider arkasol_sol1,arkasol_sag1,arkasol_sol2,arkasol_sag2,arkasag_sag1,arkasag_sol1,arkasag_sag2,arkasag_sol2;
	public float ugucu,uacisi;
	public Transform KutleMerkezi;


	void Start () {
		gameObject.GetComponent<Rigidbody> ().centerOfMass = KutleMerkezi.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
      motorayar ();

	}

	void motorayar(){
		ugucu = GameObject.Find ("pushback").GetComponent<arac> ().Guc;
		uacisi = GameObject.Find ("pushback").GetComponent<arac> ().donmeacisiSol;
	   
		arkasol_sol1.motorTorque = -ugucu;
		arkasol_sag1.motorTorque = -ugucu;
		arkasag_sag1.motorTorque = -ugucu;
		arkasag_sol1.motorTorque = -ugucu;

		arkasol_sol2.steerAngle = uacisi;
		arkasol_sag2.steerAngle = uacisi;
		arkasag_sag2.steerAngle = uacisi;
		arkasag_sol2.steerAngle = uacisi;  



	
	}
			

}
