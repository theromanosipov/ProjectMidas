using UnityEngine;
using System.Collections;

public class HitWithCrowbar : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crowbar")
        {
            transform.parent.parent.GetComponent<Animator>().SetBool("hide", false);
            transform.parent.parent.GetComponent<Animator>().SetTrigger("rage" + Random.Range(1, 4));
            MidasAnimation.AddMood(-50);
        }
    }
}
