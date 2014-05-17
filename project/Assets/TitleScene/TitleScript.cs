using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {
	const int WIDTH = 800;
	const int HEIGHT = 600;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Space))
		//if(Input.GetButtonDown("Jump"))
		{
			//spaceを押したらシーン切り替え.
			Application.LoadLevel(1);
		}
	}

	void OnGUI()
	{
		//ディスプレイの解像度を800×600と仮定する.
		GUI.matrix = Matrix4x4.TRS ( Vector3.zero, Quaternion.identity,
		                            new Vector3( Screen.width / WIDTH, Screen.height / HEIGHT, 1));
	}
}
