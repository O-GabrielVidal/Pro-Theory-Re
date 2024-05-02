using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public TMP_InputField inputField = null;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name== "Title")
        {
            inputField = GameObject.Find("Group").transform.GetChild(1).GetComponent<TMP_InputField>();
        }
    }

    public void Return()
    {
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(false);
    }

    public void SaveTheName()
    {
        SaveData.Instance.nameOfPlayer = inputField.text;
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void BeginTheGame()
    {
        if (SaveData.Instance.nameOfShapeChoiced == "Cube")
        {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }else if(SaveData.Instance.nameOfShapeChoiced == "Sphere")
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        else if (SaveData.Instance.nameOfShapeChoiced == "Capsule")
        {
            SceneManager.LoadScene(4, LoadSceneMode.Single);
        }
    }
}
