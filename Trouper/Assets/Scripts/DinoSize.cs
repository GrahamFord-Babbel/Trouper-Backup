using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoSize : MonoBehaviour {
    public GameObject Trouper;
    public GameObject Dino;
    // Use this for initialization
    bool countStart = false;
    float countdown;
    AudioSource DinoRawr;
    void Start () {
        Trouper = GameObject.Find("Trouper Cube Path");
        Trouper.SetActive(true);
        Dino = GameObject.Find("Dino");
        Dino.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if (countStart == true)
        {
            countdown += Time.deltaTime;
            if (countdown > 8.0)
            {
                Trouper.SetActive(true);
                Dino.SetActive(false);
                countStart = false;
                countdown = 0;
            }
        }
	}
    public void DinoSaur()
    {
        countStart = true;
        Trouper.SetActive(false);
        Dino.SetActive(true);
        DinoRawr = Dino.GetComponent<AudioSource>();
        DinoRawr.Play();
    }
}
