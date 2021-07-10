using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterNPC : MonoBehaviour
{
    public string SoundName;
    private Animator Anim;
    public string Animate_Name;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        FindObjectOfType<SoundManager>().AddOrigin(gameObject, SoundName);

    }

    public void GreetPlayer()
    {
        GetComponent<AudioSource>().Play();
        Anim.Play(Animate_Name);
    }
}
