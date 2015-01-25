using UnityEngine;
using System.Collections;

public class MidasAnimation : MonoBehaviour {

	public static float mood = 0;
	private float aTime;
	private float hTime;

    public static bool mouthClosed = false;

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(mood);

        if (Random.value < 0.01)
        {
            mouthClosed = !mouthClosed;
            animator.SetBool("mouthClosed", mouthClosed);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleTree") && aTime < Time.time) {
		    aTime = Time.time + 1f;

            bool random = Random.value < 20 * Time.deltaTime;
            if (mood < 30)
            {
                float random2 = Random.value;
                if (random2 < 0.1)
                    animator.SetBool("hide", true);
                else if (random2 < 0.6f)
                    animator.SetTrigger("rage1"); //+ (Mathf.RoundToInt(Random.value * 3) + 1));
                else
                    animator.SetTrigger("side" + (Mathf.RoundToInt(Random.value * 1) + 1));
            }
            else if (mood > 80 && random) 
            {
                animator.SetTrigger("happy" + (Mathf.RoundToInt(Random.value * 3) + 1));
            }
            else if (random) 
            {
                animator.SetTrigger("side" + (Mathf.RoundToInt(Random.value * 1) + 1));
            }

                //animator.SetTrigger("hide");
                //hTime = Time.time + 3 + Random.value * 3;                
            }
	
		//case 1 - 4:
		//	animator.Play("IdleTypes", );
		//	aTime=Time.time+1f;
		//	break;
	}
    public static void AddMood(float deltaMood)
    {
        mood += deltaMood;
        mood = Mathf.Clamp(mood, 0, 100);
    }
}
