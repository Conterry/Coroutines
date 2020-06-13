using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalSpeed : MonoBehaviour {

	public int param;
	private const int BIRST = 50;

	// Use this for initialization
	void Start () {
		StartCoroutine(PrintNumbers(param));
	}

	private IEnumerator TRTR()
	{
		yield return new WaitForSeconds(5);
		yield return PrintNumbers(param);
	}





	private IEnumerator PrintNumbers(int AmountNumbersToPrint)
	{
		int CountNow = 0;
		while (CountNow < AmountNumbersToPrint)
		{

			int maxNumber = CountNow + BIRST;
			if (maxNumber > AmountNumbersToPrint)
			{
				maxNumber = AmountNumbersToPrint;
			}

			while (CountNow < maxNumber)
			{
				print(CountNow);
				CountNow++;
			}

			yield return null;

		}
	}  

}
