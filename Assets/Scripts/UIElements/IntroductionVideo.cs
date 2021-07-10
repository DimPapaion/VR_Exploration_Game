using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionVideo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Player>().playerUI.SetActive(false);
        FindObjectOfType<Player>().returnToGame.SetActive(true);
        //FindObjectOfType<GameManager>().GetComponent<SoundManager>().Stop("dion");
    }

    
}
