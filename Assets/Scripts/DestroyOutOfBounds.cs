using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DestroyOutOfBounds : MonoBehaviour
{
    private float yBound = -1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y < yBound)
        {
            Destroy(gameObject);
            //Debug.Log("GAME OVER");
            //SceneManager.LoadScene("scene");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
