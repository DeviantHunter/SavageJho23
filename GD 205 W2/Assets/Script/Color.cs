using UnityEngine;
using System.Collections;

public class Color : MonoBehaviour {
	public Material[]materials;
	public Renderer rend;

	private int index = 1;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
	}
	void OnMouseDown(){
		if (materials.Length == 0) {
			return;
		}
		if (Input.GetMouseButtonDown (0)) {
			index += 1;
			if (index == materials.Length + 1) {
				index = 1;
			}
			print (index);//used for dubugging

			rend.sharedMaterial = materials [index - 1];//this sets the material color values inside the index
		}
	}
}