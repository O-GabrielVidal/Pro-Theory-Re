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
        if(SceneManager.GetActiveScene().name == "Title")
        {
            inputField = GameObject.Find("Group").transform.GetChild(1).GetComponent<TMP_InputField>();
        }else if(SceneManager.GetActiveScene().name == "FaseCapsule")
        {
            GameObject.Find("Canvas").transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Player: " + SaveData.Instance.nameOfPlayer + "\nShape choiced: " + SaveData.Instance.nameOfShapeChoiced + "\nIf you touch the white cube you will win the game. For move use the buttons A, W, D, S or the arrows.";
        }else if(SceneManager.GetActiveScene().name == "FaseCube")
        {
            GameObject.Find("Canvas").transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Player: " + SaveData.Instance.nameOfPlayer + "\nShape choiced: " + SaveData.Instance.nameOfShapeChoiced + "\nIf you touch the white cube you will win the game. For move use the buttons A, W, D, S or the arrows.";
        }else if(SceneManager.GetActiveScene().name == "FaseSphere")
        {
            GameObject.Find("Canvas").transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Player: " + SaveData.Instance.nameOfPlayer + "\nShape choiced: " + SaveData.Instance.nameOfShapeChoiced + "\nIf you touch the white cube you will win the game. For move use the buttons A, W, D, S or the arrows.";
        }else if(SceneManager.GetActiveScene().name == "Final")
        {
            StartCoroutine(Espera());//End the game
        }

    }

    // ABSTRACTION
    public void Return()
    {
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(false);
    }

    // ABSTRACTION
    public void SaveTheName()
    {
        SaveData.Instance.nameOfPlayer = inputField.text;
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    // ABSTRACTION
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

    // ABSTRACTION
    IEnumerator Espera()
    {
        yield return new WaitForSeconds(2);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
