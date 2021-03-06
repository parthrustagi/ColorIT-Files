using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon2Controller : MonoBehaviour
{
    public GameObject[] selectionArray;
    public Texture2D cursor;
    public GameObject [] otherButtons;

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.7f;

    public GameObject window;

    private void OnMouseDown()
    {
        selectionArray[0].SetActive(false);
        selectionArray[1].SetActive(false);
        selectionArray[2].SetActive(true);


        if (clicked == 0){
            clicked++;
            clicktime = Time.time;
        }else{
            float currentTime = Time.time;
            if (currentTime - clicktime < clickdelay){
                // Double Click Detected
                window.SetActive(true);
                foreach (GameObject button in otherButtons)
                {
                    button.SetActive(false);
                }
            }
            clicktime = Time.time;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
