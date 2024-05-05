using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class sphere : shape
{
    GameObject screen;//Canvas
    private string definition = "A round solid figure, or its surface, with every point on its surface equidistant from its center.";
    public string nameShape { get; private set; }
    [SerializeField]
    private float velocity = 15f;

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
        if (SceneManager.GetActiveScene().name == "FaseSphere")
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(-1, 0, 0) * velocity * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(1, 0, 0) * velocity * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(new Vector3(0, 0, 1) * velocity * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(new Vector3(0, 0, -1) * velocity * Time.deltaTime);
            }
        }
    }

    private void OnMouseDown()
    {
        if(SceneManager.GetActiveScene().name== "SampleScene")
        {
            screen.transform.GetChild(0).gameObject.SetActive(true);//Active the screen with info
            DisplayText(screen.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>(), definition);
            name = "Sphere";
            SaveData.Instance.nameOfShapeChoiced = nameShape;
        }
    }
}
