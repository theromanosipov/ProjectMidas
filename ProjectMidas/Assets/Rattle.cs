using UnityEngine;
using System.Collections;

public class Rattle : MonoBehaviour {

    private Vector3 oldPosition;

	void Start () {
	
	}
	
	void Update () {
        MidasAnimation.AddMood(Vector3.Distance(oldPosition, transform.position) * 0.5f);
        oldPosition = transform.position;
	}
}
