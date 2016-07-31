using UnityEngine;
using System.Collections;
//using UnityEngine.Networking;

public class blockStatus :  MonoBehaviour {
	
	public GameObject preObj;
	public GameObject nextObj;



	int clickCount = 0;

	// Use this for initialization
	void Start () {
		
	}
		
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
				
				Vector3 aTapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Collider2D aCollider2d = Physics2D.OverlapPoint (aTapPoint);

				if (aCollider2d) {
					clickCount++;
					if (clickCount == 1) {
						preObj = aCollider2d.transform.gameObject;
						preObj.GetComponent<Renderer> ().material.color = Color.red;
					} else if (clickCount == 2) {
						nextObj = aCollider2d.transform.gameObject;					    
						Vector2 direction = new Vector2 (0, 0);
						direction.x = nextObj.transform.position.x - preObj.transform.position.x;
						direction.y = nextObj.transform.position.y - preObj.transform.position.y;
						nextObj.GetComponent<Renderer> ().material.color = Color.red;
					    GameObject[] blocks = GameObject.FindGameObjectsWithTag ("BLOCK");
						foreach (GameObject target in blocks) {
							if (direction.x == 0 && direction.y > 0) {
								if (target.transform.position.x == nextObj.transform.position.x) {
									if ((preObj.transform.position.y < target.transform.position.y) && (target.transform.position.y < nextObj.transform.position.y)) {
										target.GetComponent<Renderer> ().material.color = Color.red;
									}
								}
							} else if (direction.x == 0 && direction.y < 0) {
								if (target.transform.position.x == nextObj.transform.position.x) {
									if ((preObj.transform.position.y > target.transform.position.y) && (target.transform.position.y > nextObj.transform.position.y)) {
										target.GetComponent<Renderer> ().material.color = Color.red;
									}
								}
							} else if (direction.y == 0 && direction.x > 0) {
								if (target.transform.position.y == nextObj.transform.position.y) {
									if ((preObj.transform.position.x < target.transform.position.x) && (target.transform.position.x < nextObj.transform.position.x)) {
										target.GetComponent<Renderer> ().material.color = Color.red;
									}
								}
							} else if (direction.y == 0 && direction.x < 0) {
								if (target.transform.position.y == nextObj.transform.position.y) {
									if ((preObj.transform.position.x > target.transform.position.x) && (target.transform.position.x > nextObj.transform.position.x)) {
										target.GetComponent<Renderer> ().material.color = Color.red;
									}
								}
							} 
						}
						clickCount = 0;
						preObj = null;
						nextObj = null;
						
					}
				}
			}

	  }

}
