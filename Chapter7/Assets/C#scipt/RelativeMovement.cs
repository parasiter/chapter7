using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelativeMovement : MonoBehaviour {
	[SerializeField] private Transform target;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = Vector3.zero;
		float horInput = Input.GetAxis ("horizontal");
		float vertInput = Input.GetAxis ("Vertical");
		if(horInput!=0||vertInput!=0){
			movement.x = horInput;
			movement.z = vertInput;

			Quaternion temp = target.rotation;
			target.eulerAngles = new Vector3 (0, target.eulerAngles.y, 0);
			movement = target.TransformDirection (movement);
			target.rotation = temp;

			transform.rotation = Quaternion.LookRotation (movement);
	}
}
