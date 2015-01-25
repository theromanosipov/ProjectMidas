using UnityEngine;
using System.Collections;

public class HitWithCrowbar : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crowbar")
        {
            transform.parent.parent.GetComponent<Animator>().SetBool("hide", false);
            transform.parent.parent.GetComponent<Animator>().SetTrigger("rage1"); //+ (Mathf.RoundToInt(Random.value * 3) + 1));
            MidasAnimation.AddMood(-50);
        }
    }
}
