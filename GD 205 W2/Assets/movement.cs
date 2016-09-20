using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	
	public float move = 18;
	private Rigidbody rig;
	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		float hAxis = Input.GetAxis ("Horizontal");
		float vAxis = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (hAxis, 0, vAxis) * move * Time.deltaTime;

		rig.MovePosition (transform.position + movement);
	}
}
