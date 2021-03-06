using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{
    
    private Rigidbody rBody;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
     
    }

    IEnumerator delayDeath()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);
        
    }
    void OnCollisionEnter(Collision collision)
    {
        // Switch statement to handle collisions with different objects
        switch (collision.gameObject.tag)
        {
            case "Friedfly":
                Debug.Log("Friendly Collision");
                break;
            case "Finish":
                Debug.Log("Level Finished");
                LoadNextLevel();
                break;
            case "Power Up":
                Debug.Log("Power Up Collision");
                break;
            case "Hazard":
                ReloadLevel();
                break;
            default:
                break;

        }
    }

    private void LoadNextLevel()
    {
        int scene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    private void ReloadLevel()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}