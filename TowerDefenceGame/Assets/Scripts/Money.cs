using UnityEngine;
using System.Collections;

public class Money : MonoBehaviour {
	private int startMoney = 100;
	public static int currentMoney = 100;

	// Use this for initialization
	void Start () {
		currentMoney = startMoney;
	}
}
