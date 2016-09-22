using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //get the current screen position of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;      //1
        //the camera's z position sets the how far to push the mouse into 3d
        mousePos2D.z = -Camera.main.transform.position.z;    //2
        //convert the point from 2d screen space into 3d game world
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);   //3
        //move the x position of this basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
	}

    void OnCollisionEnter (Collision coll)
    {
        //find out what hit this basket
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
        }
    }

}
