using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class UseObjectTextDialog : MonoBehaviour, UsableInterface 
{
    public string text;
    public Canvas canvas;

    public void Use()
    {
        if (!canvas.isActiveAndEnabled)
        {
            canvas.gameObject.SetActive(true);
            canvas.enabled = true;
        }
        DialogText dialogText = DialogText.getInstance();
        dialogText.setText(text);
    }
}
