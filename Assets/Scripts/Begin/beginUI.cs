﻿using UnityEngine;
using System.Collections;

public class beginUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadChapter1_1(){
		Application.LoadLevel ("Level1"); 
	}


	public void loadChapter1_2(){
		Application.LoadLevel ("Level2"); 
	}

	public void loadChapter1_3(){
		Application.LoadLevel ("Level3"); 
	}

}
