using UnityEngine;
using System.Collections;

public class HealthShips3 : MonoBehaviour {
	public PlayerController target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (target.health <= 0){
			Destroy(gameObject);
		}
	}
}
