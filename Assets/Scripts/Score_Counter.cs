using UnityEngine;
using System.Collections;

public class Score_Counter : MonoBehaviour {
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		this.guiText.text = "" + score;	
	}
}
