using UnityEngine;
using System.Collections;

public class grabable : MonoBehaviour {


	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player")
						other.GetComponent<HandControl>().PickObject(gameObject);
	}
}
