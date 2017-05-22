using UnityEngine;
using System.Collections;

public class Player_Move : MonoBehaviour {
	public GameObject player;
	float min_z;
	// Use this for initialization
	void Start () {
		min_z = player.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		if(min_z + 3 < player.transform.position.z){
			min_z += 3;
		}
		if(Input.GetKeyDown("w")){
			Debug.Log("w");
			player.transform.position += new Vector3(0,0,1);
		}
		if(Input.GetKeyDown("a")){
			player.transform.position += new Vector3(-1,0,0);
		}
		if(Input.GetKeyDown("s") && player.transform.position.z > min_z){
			player.transform.position += new Vector3(0,0,-1);
		}
		if(Input.GetKeyDown("d")){
			player.transform.position += new Vector3(1,0,0);
		}

	}
}
