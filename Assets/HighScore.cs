using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    static public int
            score = 1000;
	
    void Awake()
    {
        //if the ApplePickerHighScore already exists, read it
        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        {
            score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        //assign the high score to ApplePickerHighScore
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
    }

	// Update is called once per frame
	void Update () {
        GUIText gt = this.GetComponent<GUIText>();
        gt.text = "High Score: " + score;
        //update ApplePickerHighScore in PlayerPrefs if necessary
        if (score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
	}
}
