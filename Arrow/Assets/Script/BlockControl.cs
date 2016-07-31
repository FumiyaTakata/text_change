using UnityEngine;
using System.Collections;

public class BlockControl : MonoBehaviour {

	public GameObject blockPrefab;
	public GameObject preObj;
	public GameObject nextObj;
	private Vector3 touchStartPos;
	private Vector3 touchEndPos;
	int clickCount = 0;

	/*
	void Flick(){

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			touchStartPos = new Vector3 (Input.mousePosition.x,
				Input.mousePosition.y,
				Input.mousePosition.z);
		}

		if (Input.GetKeyUp(KeyCode.Mouse0)){
			touchEndPos = new Vector3(Input.mousePosition.x,
				Input.mousePosition.y,
				Input.mousePosition.z);
			GetDirection();
		}
	}
	*/
	/*
	void GetDirection(){
		float directionX = touchEndPos.x - touchStartPos.x;
		float directionY = touchEndPos.y - touchStartPos.y;

		if (Mathf.Abs(directionY) < Mathf.Abs(directionX)){
			if (30 < directionX){
				//右向きにフリック
				Direction = "right";
			}else if (-30 > directionX){
				//左向きにフリック
				Direction = "left";
			}

		}else if (Mathf.Abs(directionX)<Mathf.Abs(directionY)){
			if (30 < directionY){
				//上向きにフリック
				Direction = "up";
			}else if (-30 > directionY){
				//下向きのフリック
				Direction = "down";
			}
		}else{
			//タッチを検出
			Direction = "touch";
		}
	}
*/
	// Use this for initialization
	void Start () {
		
		var position = new Vector3 (0, 0, 0);
		var firstPosition = new Vector3 (2, -4, 0);

		float i = 0, j = 0;
		var sr = blockPrefab.GetComponent<SpriteRenderer>();
		var width = sr.bounds.size.x;
		var height = sr.bounds.size.y;

		for (i = 0; i < 9; i++) {
			for (j = 0; j < 9; j++) {
				position.x =  firstPosition.x+i*width;
				position.y =  firstPosition.y+j*height;
				Instantiate (blockPrefab, position, Quaternion.identity);
				blockPrefab.tag = "BLOCK";
			}
		}

	}
	
	// Update is called once per frame
    void Update() {
		





	}

}