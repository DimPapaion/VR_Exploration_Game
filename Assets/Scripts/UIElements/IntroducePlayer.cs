using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroducePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
        FindObjectOfType<Player>().returnToGame.SetActive(false);
        FindObjectOfType<Player>().playerUI.SetActive(true);
        FindObjectOfType<Player>().linearMovementBehaviour.playerHeight = -12.20f;
        //FindObjectOfType<Player>().rig.SetActive(true);

    }
}
