using UnityEngine;
using System.Collections;

public class Buildplace : MonoBehaviour {
	//Tower that should be built
	public GameObject towerPrefab;

	void OnMouseUpAsButton()
	{
		//Build stuff
		GameObject g = (GameObject)Instantiate (towerPrefab);
		g.transform.position = transform.position + Vector3.up;
	}
}
