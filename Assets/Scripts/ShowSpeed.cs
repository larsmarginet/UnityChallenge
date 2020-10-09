using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSpeed : MonoBehaviour
{
    public static int speed = 1;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = speed + "X";
    }
}
