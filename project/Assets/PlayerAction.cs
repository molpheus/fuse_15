using UnityEngine;
using System.Collections;

public class PlayerAction : MonoBehaviour {
	bool flag;

	// Use this for initialization
	void Start () {
		flag = true;
	}
	
	// Update is called once per frame
	void Update () {
		//移動
		Vector3 move = new Vector3();
		//if(networkView.isMine == true)
		//{		
			move.x = Input.GetAxis("Horizontal");
			move = Vector3.ClampMagnitude(move, 1.0f/5);
		//}


		if(Input.GetKeyDown(KeyCode.Space) && flag)
		{
			gameObject.rigidbody.velocity = Vector3.up * 5;
			flag = false;
		}


		transform.position = (transform.position + move);
	}

	private void OnCollisionEnter(Collision other)
	{
		flag = true;
	}
}
