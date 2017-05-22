using UnityEngine;
using System.Collections;

public class Generate_Original : MonoBehaviour {
	public GameObject[] terrain;
	public GameObject player;
	public int generate_length;

	float max_z;
	// Use this for initialization
	void Start () {
		max_z = player.transform.position.z;
		for(int i = 0; i < generate_length; i++){
			Instantiate(terrain[Random.Range(0,3)], player.transform.position - new Vector3(0,1,-1 - i), Quaternion.identity);
		}
		for(int i = 0; i < 5; i++){
			Instantiate(terrain[Random.Range(0,3)], player.transform.position - new Vector3(0,1, 1 + i), Quaternion.identity);
			Debug.Log("i =" + i);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.z > max_z){
			max_z = player.transform.position.z;
			Instantiate(terrain[Random.Range(0,3)], player.transform.position + new Vector3(0,-1, generate_length), Quaternion.identity);

		}
	}
}
