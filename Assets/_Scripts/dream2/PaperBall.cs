﻿using UnityEngine;
using System.Collections;

public class PaperBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
