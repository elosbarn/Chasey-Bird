using UnityEngine;
using System.Collections;

public class Spawn_Obstacles : MonoBehaviour {
	public GameObject[] obstacle_pool;
	private GameObject[] obstacle_chosen;
	int obstacle_num;
	// Use this for initialization
	void Start () {
		obstacle_num = Random.Range(2,6);
		obstacle_chosen = new GameObject[obstacle_num];
		for(int i = 0; i < obstacle_num; i++){
			//Add an object from the obstacle pool
			obstacle_chosen[i] = obstacle_pool[Random.Range(0,obstacle_pool.Length)];
		}

		for(int i = 0; i < obstacle_chosen.Length; i++){
			//Instantiate each object
			Instantiate(obstacle_chosen[i], transform.position + new Vector3(Random.Range(-25,25),1, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
