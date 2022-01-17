using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSFX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        if (PlayerPrefs.GetInt("SFX") == 1)
        {
            this.gameObject.GetComponent<AudioSource>().mute = true;
        }
        else if (PlayerPrefs.GetInt("SFX") == 0)
        {
            this.gameObject.GetComponent<AudioSource>().mute = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
