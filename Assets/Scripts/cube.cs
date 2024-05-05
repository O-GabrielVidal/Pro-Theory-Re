using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class cube : shape// INHERITANCE
{
    GameObject screen;//Canvas
    private string definition = "In geometry, a cube is a three-dimensional solid object bounded by six square faces, facets, or sides, with three meeting at each vertex. Viewed from a corner, it is a hexagon and its net is usually depicted as a cross.";
    // ENCAPSULATION
    public string nameShape { get;private set; }
    [SerializeField]
    private float velocity = 15f;

    // Start is called before the first frame update
    void Start()
    {
        screen = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "FaseCube")
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
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            screen.transform.GetChild(0).gameObject.SetActive(true);//Active the screen with info
            DisplayText(screen.transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>(), definition);
            nameShape = "Cube";
            SaveData.Instance.nameOfShapeChoiced = nameShape;
        }
    }
}
