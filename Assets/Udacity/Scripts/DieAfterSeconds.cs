using UnityEngine;
using System.Collections;

public class DieAfterSeconds : MonoBehaviour {
    IEnumerator Start () {
        yield return new WaitForSeconds(2.0f);
        gameObject.SetActive(false);
        Destroy(gameObject, 0.1f);
	}
}
