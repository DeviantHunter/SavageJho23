using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public int playerX, playerZ;
	GameObject textObject; 
	public Rigidbody ra;
	// Use this for initialization
	void Start() {
		//plaerX = 5;
		//playerZ = 10000;
		//Debug.Log (transform.position);
		transform.position = new Vector3(playerX,3,playerZ);
		textObject.GetComponent<TextMesh> ().text = "Game Board";
		ra = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		playerZ = (int)transform.position.z;
		playerX = (int)transform.position.x;

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.position += new Vector3 (0, 0, 1);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			transform.position += new Vector3 (0, 0, -1);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.position += new Vector3 (-1, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.position += new Vector3 (1, 0, 0);
		}
textObject.GetComponent<TextMesh> ().text = "Position: (" +
		transform.position.x + ","+
		playerZ + ")";

		if (playerX == 0 && playerZ == 2) {//player is at the bad position
			Debug.Log("reset the player's position");
		}
		if (Input.GetButtonDown ("Jump")) {
			ra.velocity = new Vector3 (0, 8, 0);
		}
	}
}