using UnityEngine;
using System.Collections;

public class StuffSpawner : MonoBehaviour {

    public GameObject food;
    public GameObject rattle;
    public GameObject crowbar;
    public GameObject feather;

    public float time;
    private float nextTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (nextTime < Time.time)
        {
            GameObject currentObject;
            float random = Random.value;
            if (random >= 0.3)
                currentObject = food;
            else if (random < 0.1)
                currentObject = feather;
            else if (random < 0.2)
                currentObject = crowbar;
            else
                currentObject = rattle;
            Instantiate(currentObject, new Vector3((Random.value - 0.5f) * 24, 10, -0.33f), Quaternion.identity);
            nextTime = Time.time + time;
        }

	}
}
