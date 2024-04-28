using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class shape : MonoBehaviour
{
    public virtual void DisplayText(TextMeshProUGUI text, string info)
    {
        text.text= info;
    }
}
