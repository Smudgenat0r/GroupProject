using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Navigate to target
		GameObject target = GameObject.Find ("Castle");
		if (target)
			GetComponent<NavMeshAgent> ().destination = target.transform.position;
	}

	void OnTriggerEnter(Collider co){
		if (co.name == "Castle") {
			co.GetComponentInChildren<Health>().decrease();
			Destroy (gameObject);
		}
	}
}
