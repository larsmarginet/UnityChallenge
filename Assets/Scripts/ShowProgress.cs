using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowProgress : MonoBehaviour
{
    private Slider slider;
    public float fillSpeed = 0.5f;
    private float level = 200.0f;
    //private float targetProgress = 0;
    public static int progress = 0;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        progress = 0;
        slider.value = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = (progress / level);
        if (progress >= level)
        {
            FindObjectOfType<GameManager>().WinGame();
            progress = 0;
            slider.value = 0.0f;
        } 
    }
}
