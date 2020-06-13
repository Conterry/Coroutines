using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGCOMP : MonoBehaviour {




	public int param;
	private int CountNow;
	private const int BIRST	= 50;


	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		int maxNumber = CountNow + BIRST;
		if (maxNumber > param)
		{
			maxNumber = param;
		}

		while (CountNow < maxNumber)
		{
			print(CountNow);
			CountNow++;
		}

	}
}
