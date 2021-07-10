using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimations : MonoBehaviour
{
    private Animator anim;
    public string AnimName;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void SetAnim()
    {
        if (anim != null)
        {
            anim.Play(AnimName);
        }
    }
}
