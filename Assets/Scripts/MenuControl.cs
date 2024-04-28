using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public void Return()
    {
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(false);
    }
}
