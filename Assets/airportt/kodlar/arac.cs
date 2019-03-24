using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arac : MonoBehaviour {
	public WheelCollider col_onsol;
	public WheelCollider col_onsag;
	public WheelCollider col_asol;
	public WheelCollider col_asag;
	public Transform OnSol,OnSag,ArkaSol,ArkaSag;
	public Transform KutleMerkezi;
	public float MotorGucu;
	public float aci;
	public float Guc;
	public float donmeacisiSol,donmeacisiSag;

	void Start () {
		gameObject.GetComponent<Rigidbody> ().centerOfMass = KutleMerkezi.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {

		MotorAyar ();
		TekerAcisi ();
		TekerDondurme ();
		kontroller ();
	}

	 void MotorAyar(){
	
		//col_onsol.motorTorque = -MotorGucu;
		//col_onsag.motorTorque = -MotorGucu;
		col_asol.motorTorque = -MotorGucu;
		col_asol.motorTorque = -MotorGucu;

		Guc = col_asol.motorTorque;

	}


	void TekerDondurme(){
		OnSol.Rotate (0,col_onsol.rpm/60*360*Time.deltaTime,0);
		//OnSol.localEulerAngles = new Vector3 (OnSol.localEulerAngles.x,col_onsol.steerAngle-OnSol.localEulerAngles.z, OnSol.localEulerAngles.z);

		OnSag.Rotate (0,col_onsag.rpm / 60 * 360 * Time.deltaTime,0);
		OnSag.localEulerAngles = new Vector3 (OnSag.localEulerAngles.x,col_onsag.steerAngle-OnSag.localEulerAngles.z, OnSag.localEulerAngles.z);

		ArkaSol.Rotate (0, col_asol.rpm / 60 * 360 * Time.deltaTime,0);
		ArkaSol.localEulerAngles = new Vector3 (ArkaSol.localEulerAngles.x,col_asol.steerAngle-ArkaSol.localEulerAngles.z, ArkaSol.localEulerAngles.z);

		ArkaSag.Rotate ( 0, col_asag.rpm / 60 * 360 * Time.deltaTime,0);
		ArkaSag.localEulerAngles = new Vector3 (ArkaSag.localEulerAngles.x,col_asag.steerAngle-ArkaSag.localEulerAngles.z, ArkaSag.localEulerAngles.z);

	}
	void TekerAcisi(){
		col_onsol.steerAngle = aci;
		col_onsag.steerAngle = aci;
		donmeacisiSol= col_onsol.steerAngle;
		donmeacisiSag = col_onsag.steerAngle;
	}
	void kontroller ()
	{
		MotorGucu = Input.GetAxis ("Vertical") * Time.deltaTime * 7000;
		aci= Mathf.Lerp (aci,Input.GetAxis("Horizontal")*30,45);

	}
}