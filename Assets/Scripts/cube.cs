using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class cube : shape
{
    GameObject screen;//Canvas
    private string definition = "In geometry, a cube is a three-dimensional solid object bounded by six square faces, facets, or sides, with three meeting at each vertex. Viewed from a corner, it is a hexagon and its net is usually depicted as a cross.";

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
        DisplayText(screen.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>(),definition);
    }
}
