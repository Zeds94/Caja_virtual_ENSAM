﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrapsCont : MonoBehaviour {
    public int _frapcont;
    public GameObject _sac;
    public bool enter = true;
    // Use this for initialization
    void Start () {
        _frapcont = 1;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        
        if (enter)
        {
            Debug.Log("entered");
            _frapcont += 1 + _frapcont;
            /*lastInterval = Time.realtimeSinceStartup;
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0f;*/

        }
        
    }
}