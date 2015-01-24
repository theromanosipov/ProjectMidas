using UnityEngine;
using System.Collections;

public class HandControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position =Input.mousePosition;
		position.y = (2*position.y/Screen.height - 1) * 6 *(1+transform.position.z/11);
		position.x = (2*position.x / Screen.width - 1) * 8 *(1+transform.position.z/11);
		//Debug.Log (Input.mousePosition+" "+position);
		if (Input.GetMouseButton (0)) {
						if (transform.position.z > 5) {
								rigidbody.velocity = new Vector3 (0, 0, 0); 
						} else
								rigidbody.velocity = new Vector3 (0, 0, 10f);
				} else if (transform.position.z > -2)
						rigidbody.velocity = new Vector3 (0, 0, -20f);
				else 
						rigidbody.velocity = new Vector3 (0, 0, 0);
		if (Input.GetMouseButton (1) && transform.childCount != 1) {
						transform.GetChild (1).parent = null;
				}
		position.z = transform.position.z;
		transform.position = position;
	}

	public void PickObject(GameObject other)
	{
		if (transform.childCount == 1)
						other.transform.parent = gameObject.transform;
	}

	void TurnToGold()
	{
		gameObject.renderer.material.color = Color.yellow;
		}
}
