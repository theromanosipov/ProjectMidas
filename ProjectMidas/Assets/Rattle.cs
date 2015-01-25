using UnityEngine;
using System.Collections;

public class Rattle : MonoBehaviour {

    private Vector3 oldPosition;
    private grabable touchy;

    void Start()
    {
        touchy = gameObject.GetComponent<grabable>();
    }
	
	void Update () {
        if (!touchy.isGold)
        {
            MidasAnimation.AddMood(Vector3.Distance(oldPosition, transform.position) * 0.5f);
            oldPosition = transform.position;
        }
	}
}
