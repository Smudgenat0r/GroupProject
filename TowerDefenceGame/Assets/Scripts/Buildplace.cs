using UnityEngine;
using System.Collections;

public class Buildplace : MonoBehaviour {
	//Tower that should be built
	public GameObject towerPrefab;
	private bool ObjPlaced = false;

	void OnMouseUpAsButton()
	{
		if (!ObjPlaced && Money.currentMoney >= 20) {
			//Build stuff
			GameObject g = (GameObject)Instantiate (towerPrefab);
			g.transform.position = transform.position + Vector3.up;
			Money.currentMoney -= 50;
			ObjPlaced = true;
		}
	}
}
