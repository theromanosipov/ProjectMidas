using UnityEngine;
using System.Collections;

public class food : MonoBehaviour {


	void OnTriggerEnter (Collider other) {
		if (other.tag == "Finish") {
			Destroy (gameObject);
				}
	}
}
