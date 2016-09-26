﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class FlockManager : MonoBehaviour {

    public int numberOfSheep = 10;
    public GameObject sheepPrefab;
    public Transform sheepSpawn;

    private List<GameObject> sheepList;

    // Use this for initialization.
    void Start () {
        sheepList = new List<GameObject>();

        // Here the flock is created.
        for (int i = 0; i < numberOfSheep; i++) {
            addSheep();
        }
    }
	
	// Update is called once per frame.
	void Update () {
        foreach (var sheep in sheepList) {
            SheepBehaviour sheepScript = (SheepBehaviour)sheep.GetComponent(typeof(SheepBehaviour));
            sheepScript.updateSheep();
        }
	}

    private void addSheep() {
        // Create sheep.
        GameObject sheep = (GameObject)Instantiate(sheepPrefab, sheepSpawn.position, sheepSpawn.rotation);

        // Add sheep to list.
        sheepList.Add(sheep);

        //Debug.Log(sheepList.Count);
    }
}
