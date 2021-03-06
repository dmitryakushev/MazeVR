﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update()
    private bool locked = true; 
    private bool open = false;

    public AudioSource doorAudioSource;
    public AudioClip[] doorSoundFiles;

    public GameObject findAKeyMessage; 

    void Update() {
        // If the door is unlocked and it is not fully raised
            // Animate the door raising up

    	if(open && transform.position.y < 19f){
    		transform.Translate(0, 1f * Time.deltaTime, 0, Space.World);
    	}
    }

    public void Unlock()
    {
    	Debug.Log ("door is unlocked");
        // You'll need to set "locked" to true here

        locked = false;
    }

    public void onDoorClicked(){
    	if(!locked){
    		open = true;
    		doorAudioSource.clip = doorSoundFiles[1];
    		doorAudioSource.Play();
    	} else{
    		Debug.Log("You Should Find A Key!");
    		doorAudioSource.clip = doorSoundFiles[0];
    		doorAudioSource.Play();

    		Vector3 messagePosition = transform.position;
    		messagePosition.z += -1;

    		Object.Instantiate(findAKeyMessage, messagePosition, Quaternion.Euler(-20, 0, 0));
    	}
    }
}
