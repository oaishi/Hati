using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float moveSpeed;
	public GameObject bunny;
	// Use this for initialization
	void Start () {
		bunny.transform.localPosition = new Vector3 (0 , 3, 95 );//( 0, 0, 0 );
		bunny.transform.localRotation = Quaternion.Euler (18, 180, 0);

	}
	
	// Update is called once per frame
	void Update () {
		//MoveObj ();
	}

	void FixedUpdate()
	{
		MoveObj ();
	}


	void MoveObj() {		
		float moveAmount = Time.smoothDeltaTime * moveSpeed;
		transform.Translate ( 0f, 0f, moveAmount );	
	}


}
