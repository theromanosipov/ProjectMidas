using UnityEngine;
using System.Collections;

public class HitWithCrowbar : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Crowbar")
        {
            transform.parent.parent.GetComponent<Animator>().SetBool("hide", false);
            MidasAnimation.AddMood(-50);
        }
    }
}
