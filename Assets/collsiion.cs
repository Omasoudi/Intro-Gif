using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collsiion : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        // verifie si le joueur touche les piquesS
        if (other.gameObject.CompareTag("Player"))
        {
            // recharge la scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
