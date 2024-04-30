using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class sphere : shape
{
    GameObject screen;//Canvas
    private string definition = "A round solid figure, or its surface, with every point on its surface equidistant from its center.";

    public override void DisplayText(TextMeshProUGUI text, string info)
    {
        text.text = "<rotate=-75>" + definition + "</rotate>";
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
