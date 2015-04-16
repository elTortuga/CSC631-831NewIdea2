﻿using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
    public GameObject map;
    public GameObject endFlag;
	public GameObject item1;
	public ArrayList items;
	private GameCamera cam;
    private float raceTime;
    private static float startPoint = 0;
    private static float endPoint;

	// Use this for initialization
	void Start () {

		cam = GetComponent<GameCamera> ();
        SpawnMap();
		SpawnPlayer ();
		Instantiate (player2, Vector3.zero, Quaternion.identity);
        raceTime = 0;
		//Debug.Log("Before!!!!!!!!!");

		items = new ArrayList();
		//repeat until none
		// item = new GO();
		// PlaItem(item, xy);
		// items.Add (items);

		GameObject.Find("GameLogic").GetComponent<Running>().RunOnce();

	}
	
	private void SpawnPlayer() {
		cam.SetTarget(( Instantiate (player1, Vector3.zero, Quaternion.identity) as GameObject).transform);
	}

    private void SpawnMap()
    {

        float tempEnd = 20;
        for (int i = 0; i < 20; i++)
        {
            tempEnd += 62.9f;
           Instantiate(map, new Vector3((float)(20 + (i * 62.9)), 0.507454f, 0), Quaternion.identity);



            //Instantiate(Resources.Load("Prefabs/map/MapVariation1", typeof(GameObject)), new Vector3((float)(20 + (i * 62.9)), 0.507454f, 0), Quaternion.identity) as GameObject;
        }

        endPoint = tempEnd - 62.9f;

        Instantiate(endFlag, new Vector3(tempEnd, 0.507454f, 0), Quaternion.identity);
    } 

	private void PlaceItem(GameObject itemType, Vector2 vect) {
		Instantiate (itemType, Vector3.zero, Quaternion.identity);
	}
}
