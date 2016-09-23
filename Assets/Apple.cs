﻿using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {

    public static float
        bottomY = -20f;
	
	// Update is called once per frame
	void Update () {
	if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

            //get a reference to the ApplePicker component of Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            //call the public AppleDestroyed() method of apScript
            apScript.AppleDestroyed();
        }
	}
}
