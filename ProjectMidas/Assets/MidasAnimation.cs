using UnityEngine;
using System.Collections;

public class MidasAnimation : MonoBehaviour {

	public float mood=.5f;
	private float aTime;
	private float hTime;
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		mood += (Random.value-0.5f)/12;
		if (hTime!=0)
		{
		if (hTime > Time.time)
						return;
				else {
				animator.ResetTrigger("hide"); //SetTrigger ("hide").Equals=false;
				hTime=0;
		}
		}
		if (Input.GetMouseButtonDown (0))
						mood += 0.05f;
		if (Input.GetMouseButtonDown (1))
			mood =Random.value;
		mood = Mathf.Clamp (mood, 0, 1);
		if (!animator.GetCurrentAnimatorStateInfo(0).IsName("IdleTree")||aTime>Time.time)
			return;
		aTime=Time.time+0.1f;
		switch (Mathf.RoundToInt(mood*10)) {
		case 0:
		case 1:
		case 2:
			animator.SetTrigger("rage"+(Mathf.RoundToInt(Random.value*3)+1));
			break;
		case 3:
			animator.SetTrigger ("hide");
			hTime=Time.time+3+Random.value*3;
			break;
		case 4:
		case 5:
			animator.SetTrigger("side"+(Mathf.RoundToInt(Random.value*1)+1));
			break;
		case 6:
		case 7:
		case 8:
			animator.SetTrigger("happy"+(Mathf.RoundToInt(Random.value*3)+1));
			break;
	
		//case 1 - 4:
		//	animator.Play("IdleTypes", );
		//	aTime=Time.time+1f;
		//	break;
		}
	}
}
