using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {

    //prefab for instantiating apples
    public GameObject
        applePrefab;
    //speed at which the AppleTree moves in meters/second
    public float
        speed = 1f;
    //distance where AppleTree turns around
    public float
        leftAndRightEdge = 10f;
    //chance that AppleTree will change directions
    public float
        chanceToChangeDirections = 0.1f;
    //rate at which apples will be instantiated
    public float
        secondsBetweenAppleDrops = 1f;


	// Use this for initialization
	void Start () {
	//dropping apples every second
	}
	
	// Update is called once per frame
	void Update () {
	//basic movement
    //changing direction
	}
}
