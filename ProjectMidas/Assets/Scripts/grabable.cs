using UnityEngine;
using System.Collections;

public class grabable : MonoBehaviour {

	bool isGold = false;

	void OnTriggerEnter (Collider other) {
        if (other.tag == "Player" && !isGold)
        {
            other.GetComponent<HandControl>().PickObject(gameObject);
            rigidbody.useGravity = false;
        }
	}

	public void TurnToGold()
	{
        if (!isGold)
        {
            rigidbody.useGravity = true;
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
            renderer.color = Color.yellow;
            isGold = true;
            transform.parent = null;
        }
	}
}
