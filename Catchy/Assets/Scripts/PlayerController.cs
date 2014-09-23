using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	public KeyCode moveLeft;
	public KeyCode moveRight;
	private bool leftMovement = false;
	private bool rightMovement = true;
	public Animator Anim;

	void Start()
	{
		Anim = GetComponent<Animator> ();
	}
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (moveRight)) {
			if(!rightMovement)
			{
				transform.RotateAround(Vector3.up, Mathf.PI);
				rightMovement = true;
				leftMovement = false;
			}
			Vector3 v = rigidbody2D.velocity;
			v.x = speed;
			rigidbody2D.velocity = v;	
			Anim.SetBool("IsRunning",true);
		}
		else if (Input.GetKey (moveLeft)) {
			if(!leftMovement)
			{
				transform.RotateAround(Vector3.up, Mathf.PI);
				leftMovement = true;
				rightMovement = false;
			}
			Vector3 v = rigidbody2D.velocity;
			v.x = speed * -1;
			rigidbody2D.velocity = v;
			Anim.SetBool("IsRunning",true);;
		}
		else{
			Vector3 v = rigidbody2D.velocity;
			v.x = 0;
			rigidbody2D.velocity = v;
			Anim.SetBool("IsRunning",false);
		}
	}


}
