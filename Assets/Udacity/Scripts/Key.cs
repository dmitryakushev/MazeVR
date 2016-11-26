using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject objectToReplaceKey;
    public GameObject doorToUnlock;

	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        Object.Instantiate(objectToReplaceKey, transform.position, Quaternion.Euler(-90, 0, 0));
        
        // Call the Unlock() method on the Door
        //I call the Unlock() methode VIA event trigger in Unity.
        
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

}
