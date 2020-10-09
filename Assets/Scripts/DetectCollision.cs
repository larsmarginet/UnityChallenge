using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DetectCollision : MonoBehaviour
{
    public AudioSource upgradeSound;
    public ParticleSystem explosion;
    void Start()
    {
        upgradeSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }


    private void ChangeColor(GameObject cube)
    {
        foreach (Renderer r in cube.GetComponentsInChildren<Renderer>())
        {
            r.material.color = new Color(0.2f, 0.2f, 0.2f, 0.1f); ;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if ball collides with floor, destroy the tile after 1 sec
        if (other.gameObject.name.Contains("Trigger"))
        {
            //Update Pogress bar
            ShowProgress.progress++;

            //Change the color of the cube
            ChangeColor(other.gameObject);

            //Destroy cube with 1s delay
            Destroy(other.gameObject, 1.0f);
        }
        //if ball collides with upgrade, speed up ball
        else if (other.gameObject.name.Contains("Upgrade"))
        {
            //Play sound
            upgradeSound.Play();

            //Destroy upgrade
            Destroy(other.gameObject);

            //Increment the horizontal & vertical speed of the ball
            gameObject.GetComponent<PlayerControls>().verticalSpeed += 0.5f;
            gameObject.GetComponent<PlayerControls>().horizontalSpeed += 0.5f;

            //update speed number in UI
            ShowSpeed.speed += 1;
        }
    }
}
