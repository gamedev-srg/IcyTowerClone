using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Controls level transition the moment the player finishes the current level
 */
public class LevelControl : MonoBehaviour
{
    Scene currentScene;
    string currentSceneName;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        
    }
}
