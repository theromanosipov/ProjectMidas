using UnityEngine;
using System.Collections;

public class Destroyleaving : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
	    Destroy(other.gameObject);
	}
	
	
	}