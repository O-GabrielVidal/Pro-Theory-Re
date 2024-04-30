using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class capsule : shape
{
    GameObject screen;//Canvas
    private string definition = "A small case or container, especially a round or cylindrical one.";

    public override void DisplayText(TextMeshProUGUI text, string info)
    {
        base.DisplayText(text, info);
    }

    // Start is called before the first frame update
    void Start()
    {
        screen = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        screen.transform.GetChild(0).gameObject.SetActive(true);//Active the screen with info
        DisplayText(screen.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>(), definition);
    }
}
