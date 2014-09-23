using UnityEngine;
using System.Collections;

public class popScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		Invoke ("Die", 0.3f);
	}
	
	// Update is called once per frame
	void Die()
	{
		Destroy (gameObject);
	}
}
