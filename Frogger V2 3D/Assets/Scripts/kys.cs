using UnityEngine;
using System.Collections;

public class kys : MonoBehaviour {
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.z - transform.position.z > 10){
			Destroy(gameObject);
		}
	}
}
