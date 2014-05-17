using UnityEngine;
using System.Collections;

public class CameraAction : MonoBehaviour {
	public GameObject player;
	Vector3 camVec;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		//ターゲットの方を向く.
		transform.LookAt (player.transform.position);
			
		//移動させる.
		camVec = new Vector3 (0, 0, -5);

		transform.position = player.transform.position + camVec;
	}
}
