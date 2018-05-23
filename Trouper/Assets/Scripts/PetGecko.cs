using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetGecko : MonoBehaviour {
    Animator anim1;
    float countdown;
    public float stopPetting;
    public GameObject hand;
    bool startcount;

	// Use this for initialization
	void Start () {
        anim1 = GameObject.Find("cheaphand 5.19").GetComponent<Animator>();
        anim1.enabled = false;
        hand = GameObject.Find("PositionReset");
        hand.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (startcount == true)
        {
            countdown += Time.deltaTime;
            if (countdown > stopPetting)
            {
                hand.SetActive(false);
                countdown = 0;
            }
        }
    }
    public void PetTroups()
    {
        startcount = true;
        hand.SetActive(true);
        anim1.enabled = true;
        
    }
}
