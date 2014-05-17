using UnityEngine;
using System.Collections;

public class PlayerAction : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//移動
		Vector3 move = new Vector3();
		//if(networkView.isMine == true)
		//{		
			//move.x = Input.GetAxis("Horizontal");
			//move = Vector3.ClampMagnitude(move, 1.0f/10);
		//}

		Quaternion newRotation = transform.localRotation;
		if(Input.GetKey(KeyCode.RightArrow))
		{
			move = Vector3.right * 0.05f;

			newRotation.eulerAngles = new Vector3(0, 90, 0);
			transform.localRotation = newRotation;
		}

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			move = Vector3.left * 0.05f;
			newRotation.eulerAngles = new Vector3(0, -90, 0);
			transform.localRotation = newRotation;
		}

		transform.position = (transform.position + move);
	}

}
