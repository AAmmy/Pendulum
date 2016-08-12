using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public GameObject pen;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 40; i++){
			GameObject obj = Instantiate(pen, new Vector3(0, 0, i / 2f), this.transform.rotation) as GameObject;
			obj.GetComponent<Manager>().l = i / 4f + 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
