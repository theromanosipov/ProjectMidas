using UnityEngine;
using System.Collections;

public class grabable : MonoBehaviour {

	bool isGold=false;
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player"&&!isGold)
						other.GetComponent<HandControl>().PickObject(gameObject);
	}

	void TurnToGold()
	{
		gameObject.renderer.material.color = Color.yellow;
		isGold = true;
		transform.parent = null;
		if(gameObject.GetComponent<Rigidbody>()==null)
		gameObject.AddComponent<Rigidbody>();
	}
}
