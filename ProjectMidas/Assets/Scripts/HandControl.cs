using UnityEngine;
using System.Collections;

public class HandControl : MonoBehaviour {

    public GameObject youAreGolden;
	public Material gold;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position =Input.mousePosition;
		position.y = (2*position.y/Screen.height - 1) * 7 *(1+transform.position.z/11);
		position.x = (2*position.x / Screen.width - 1) * 12 *(1+transform.position.z/11);
		//Debug.Log (Input.mousePosition+" "+position);
		if (Input.GetMouseButton (0)) {
			if (transform.position.z > 5) {
				rigidbody.velocity = new Vector3 (0, 0, 0); 
			} else
				rigidbody.velocity = new Vector3 (0, 0, 10f);
		} else if (transform.position.z > 0)
			rigidbody.velocity = new Vector3 (0, 0, -20f);
		else 
			rigidbody.velocity = new Vector3 (0, 0, 0);
		if (Input.GetMouseButton (1) && transform.childCount != 1) {
            transform.GetChild(1).gameObject.rigidbody.useGravity = true;
            transform.GetChild(1).parent = null;
        }
		position.z = transform.position.z;
		transform.position = position;
	}

	public void PickObject(GameObject other)
	{
        if (transform.childCount == 1)
        {
            other.rigidbody.useGravity = false;
            other.transform.parent = gameObject.transform;
        }
	}

	void TurnToGold()
	{
        Instantiate(youAreGolden);
		gameObject.transform.GetChild (0).gameObject.renderer.material = gold;
		gameObject.GetComponent<HandControl> ().enabled = false;
		gameObject.rigidbody.useGravity = true;
		rigidbody.velocity = new Vector3 (0, rigidbody.velocity.y, 0);
        if (transform.childCount != 1)
        {
            transform.GetChild(1).gameObject.rigidbody.useGravity = true;
            transform.GetChild(1).parent = null;
        }
		}
}
