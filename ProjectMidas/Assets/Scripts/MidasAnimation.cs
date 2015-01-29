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
        AddMood(Time.deltaTime * -1);

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
                    animator.SetTrigger("rage" + Random.Range(1, 4));
                else
                    animator.SetTrigger("side" + Random.Range(1, 3));
            }
            else if (mood > 80 && random)
            {
                animator.SetTrigger("happy" + Random.Range(1, 5));
            }
            else if (random) 
            {
                animator.SetTrigger("side" + Random.Range(1, 3));
            }

                //animator.SetTrigger("hide");
                //hTime = Time.time + 3 + Random.value * 3;                
            }
        else if (mood > 90&&animator.GetBool("hide"))
        {
            animator.SetBool("hide", false);
            animator.SetTrigger("happy" + Random.Range(1, 5));
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
