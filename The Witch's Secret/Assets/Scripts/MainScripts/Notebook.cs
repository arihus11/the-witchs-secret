using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{
    // Start is called before the first frame update
    public bool notClicked = true;
    public static bool noteBookOpened;
    public Vector3 pomocni;
    void Start()
    {
        noteBookOpened = false;
        GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(5).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseUp()
    {
        if (OpenNote.noteOpened == false)
        {
            if (notClicked == true)
            {
                noteBookOpened = true;
                GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(5).gameObject.SetActive(true);
                pomocni = GameObject.FindGameObjectWithTag("note")
                    .gameObject.transform.GetChild(5).gameObject.transform.position;
                GameObject.FindGameObjectWithTag("note")
                .gameObject.transform.GetChild(5).gameObject.transform.position = new Vector3(0, 0, 0);
                notClicked = false;
            }
            else
            {
                noteBookOpened = false;
                GameObject.FindGameObjectWithTag("note").gameObject.transform.GetChild(5).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("note")
                    .gameObject.transform.GetChild(5).gameObject.transform.position = pomocni;
                notClicked = true;
            }
        }
    }
}
