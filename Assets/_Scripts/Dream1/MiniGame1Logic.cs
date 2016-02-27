using UnityEngine;
using System.Collections;

public class MiniGame1Logic : MonoBehaviour {

	private Transform canvasTransform;

	void Start()
	{
		canvasTransform = GameObject.Find("Canvas").transform;

	}

	void Update()
	{
		if(canvasTransform.childCount == 1)
		{
			EndDream();
        }
	}

	private void EndDream()
	{
		Debug.Log("End");
	}
}
