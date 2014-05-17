using UnityEngine;
using System.Collections;

public class UnityChanAnim : MonoBehaviour {
	bool flag = true;

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("right") || Input.GetKey("left")) {
			animator.SetBool("is_running", true);
		} else {
			animator.SetBool("is_running", false);
		}

		if (Input.GetKey ("space") && flag) {
			flag = false;
			StartCoroutine("StartJump");
		} 
	}

	IEnumerator StartJump()
	{
		animator.SetBool("is_jump", true);
		animator.SetBool("wait_jump", true);
		yield return new WaitForSeconds(0.6f);

		gameObject.rigidbody.velocity = Vector3.up * 5;
	}

	private void OnCollisionEnter(Collision other)
	{
		animator.SetBool("is_jump", false);
		animator.SetBool("wait_jump", false);
		flag = true;
	}
}