using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class capsule : shape// INHERITANCE
{
    GameObject screen;//Canvas
    private string definition = "A small case or container, especially a round or cylindrical one.";
    // ENCAPSULATION
    public string nameShape { get;private set; }
    [SerializeField]
    private float velocity = 15f;

    // POLYMORPHISM
    public override void DisplayText(TextMeshProUGUI text, string info)
    {
        text.text = definition + "\n<sprite=4>\n<sprite=4>\n<sprite=4>";
    }

    // Start is called before the first frame update
    void Start()
    {
        screen = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "FaseCapsule")
        {
            if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(-1, 0, 0) * velocity * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(1, 0, 0) * velocity * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(new Vector3(0, 0, 1) * velocity * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
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
            nameShape = "Capsule";
            SaveData.Instance.nameOfShapeChoiced = nameShape;
        }
    }
}
