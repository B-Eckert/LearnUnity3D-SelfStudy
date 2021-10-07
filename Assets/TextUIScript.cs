using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUIScript : MonoBehaviour
{

    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Number of Collisions:" + FindObjectOfType<PlayerMovement>().collideCounter;
    }
}
