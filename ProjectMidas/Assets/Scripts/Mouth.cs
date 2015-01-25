using UnityEngine;
using System.Collections;

public class Mouth : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food" && !MidasAnimation.mouthClosed)
        {
            Destroy(other.gameObject);
        }
    }
}
