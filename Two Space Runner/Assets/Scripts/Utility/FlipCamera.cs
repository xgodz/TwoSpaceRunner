﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCamera : MonoBehaviour {

	// Use this for initialization
	void Start ()
  {
    Matrix4x4 mat = Camera.main.projectionMatrix;
    mat *= Matrix4x4.Scale(new Vector3(1, -1, 1));
    Camera.main.projectionMatrix = mat;
  }
	
	// Update is called once per frame
	void Update () {
		
	}
}
