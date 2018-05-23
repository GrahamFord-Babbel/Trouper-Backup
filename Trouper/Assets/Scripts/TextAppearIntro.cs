using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAppearIntro : MonoBehaviour {
    public GameObject disclosureText;
    // Use this for initialization
    void Start () {
        //disclosureText.GetComponent<Text>();
        disclosureText.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        //print(Time.time);
        disclosureText.SetActive(false);
        if (Time.time > 5.0 & Time.time < 10.0)
        {
            disclosureText.SetActive(true);
            //print("text active");
        }
    }
}
