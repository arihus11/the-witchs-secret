using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture2D cursorArrow;
    void Start()
    {
       // PlayerPrefs.DeleteAll();
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
