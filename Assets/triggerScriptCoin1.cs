using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerScriptCoin1 : MonoBehaviour
    
{
    public GameObject coin2;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the player
        if (other.gameObject.CompareTag("Player"))
        {

            Destroy(coin2);
        }
    }
}
