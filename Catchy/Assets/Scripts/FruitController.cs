using UnityEngine;
using System.Collections;

public class FruitController : MonoBehaviour {
	public AudioClip pop;
	public GameObject popped;

	void OnCollisionEnter2D(Collision2D Other)
	{
		if (Other.collider.tag == "Player") {
			if (gameObject != null)
			{   
				Instantiate(popped,gameObject.transform.position,Quaternion.identity);
				AudioSource.PlayClipAtPoint(pop, gameObject.transform.position);
				TextMesh textMesh = (TextMesh)gameObject.GetComponentInChildren (typeof(TextMesh));
				int num = System.Convert.ToInt32(textMesh.text);
				if(num % 2 == 0)
					GameManager.rightIncrement();
				else
					GameManager.wrongIncrement();

				Destroy(gameObject);
			}
		}
	}
}
