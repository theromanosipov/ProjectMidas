using UnityEngine;
using System.Collections;

public class GoldenHand : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag!="Midas")
			other.SendMessage("TurnToGold");
	}
}
