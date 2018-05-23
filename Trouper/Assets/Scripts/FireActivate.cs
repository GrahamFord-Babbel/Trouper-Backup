using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireActivate : MonoBehaviour {
    public GameObject trouperfire;
    AudioSource FireSound;
	// Use this for initialization
	void Start () {
        trouperfire = GameObject.Find("myfire");
        trouperfire.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        //if (trouperfire.activeSelf == true)
        //{
        //    FireSound = trouperfire.GetComponent<AudioSource>();
        //    FireSound.Play();
        //}
        
    }
    public void FireStart()
    {
        
        trouperfire.SetActive(true);
        FireSound = trouperfire.GetComponent<AudioSource>();
        FireSound.Play();
    }
}
