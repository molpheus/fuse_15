using UnityEngine;
using System.Collections;

public class Lance : MonoBehaviour {
	static int count;
	public int moveTime;
	// Use this for initialization
	void Start () {
		count = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (count > moveTime) {
			count = 0;
		}

		count++;

		if (count < 20) {
			transform.Translate(0,0.5f,0);
		}

		if (count > 50 && count <= 100) {
			Vector3 v =	transform.position;
			if(v.y >= 0 ){ 
				transform.Translate(0,-0.2f,0);
			}
		}
	}
}
