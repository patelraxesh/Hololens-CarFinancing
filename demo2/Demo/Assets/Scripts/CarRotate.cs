using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotate : MonoBehaviour {

	int t_corolla = 18680;
	int t_prius = 21000;
	int t_camry = 23500;

	// Use this for initialization
	void Start () {
		print ("This is car shop");
		print ("Toyota camry's price is " + t_camry);

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			print ("Up arrow");
	}
}
}
