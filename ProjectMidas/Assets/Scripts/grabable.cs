using UnityEngine;
using System.Collections;

public class grabable : MonoBehaviour {

	public bool isGold = false;

	void Update()
    {
        if (transform.parent != null)
            transform.position = transform.parent.position+new Vector3(0,0,1);

    }
    
    void OnTriggerEnter (Collider other) {
        if (other.tag == "Player" && !isGold)
        {
            other.GetComponent<HandControl>().PickObject(gameObject);
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
