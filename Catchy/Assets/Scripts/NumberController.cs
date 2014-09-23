using UnityEngine;
using System.Collections;

public class NumberController : MonoBehaviour {
	// Use this for initialization
	void Start () {
		int randomNumber = System.Convert.ToInt32 (Random.Range (1, 20));
		TextMesh textMesh = (TextMesh)gameObject.GetComponent (typeof(TextMesh));
		textMesh.text = randomNumber.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
