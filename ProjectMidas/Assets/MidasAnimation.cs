using UnityEngine;
using System.Collections;

public class MidasAnimation : MonoBehaviour {

	public float mood=.5f;
	private float aTime;
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		mood += (Random.value-0.5f)/12;
		if (Input.GetMouseButtonDown (0))
						mood += 0.05f;
		if (Input.GetMouseButtonDown (1))
			mood -= 0.05f;
		mood = Mathf.Clamp (mood, 0, 1);
		Debug.Log (Mathf.RoundToInt (mood * 5));
		if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Idle")||Time.time<aTime)
			return;
		switch (Mathf.RoundToInt(mood*5)) {
		case 0:
			animator.Play("Rage");
			break;
		case 5:
			animator.Play("Happy");
			break;
		case 1 - 4:
			animator.Play("Idle");
			aTime=Time.time+1f;
			break;
		}
	}
}
