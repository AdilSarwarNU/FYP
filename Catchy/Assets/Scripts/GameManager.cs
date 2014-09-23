using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	private int fruitCount;
	public GameObject fruit;

	private static int rightCounter = 0;
	private static int wrongCounter = 0;

	// Use this for initialization
	void Start () {
		fruitCount = 5;
		StartCoroutine(spawnFruit());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator spawnFruit()
	{
		for (int i= 0; i<fruitCount; i++) {
			int randomNumber = System.Convert.ToInt32 (Random.Range (1, 5));
			Instantiate(fruit,new Vector3(transform.position.x+randomNumber, 8.0f, transform.position.z),transform.rotation);
		yield return new WaitForSeconds (3);
			Instantiate(fruit,new Vector3(transform.position.x-randomNumber, 8.0f, transform.position.z),transform.rotation);
			yield return new WaitForSeconds (5);
			
		}
	}

	public static void rightIncrement()
	{
		rightCounter++;
		Debug.Log ("Right Counter: " + rightCounter);
	}

	public static void wrongIncrement()
	{
		wrongCounter++;
		Debug.Log ("Wrong Counter: " + wrongCounter);
	}
}
