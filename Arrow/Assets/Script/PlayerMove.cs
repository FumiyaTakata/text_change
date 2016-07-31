using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour {
	public float speed = 5f;
	private Vector2 target;

	// Use this for initialization
	void Start () {
		target = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (isLocalPlayer) {
			if (Input.GetMouseButton(0))
			{
				target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.x, target.y), speed * Time.deltaTime);
		}
	 }
}

