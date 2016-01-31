using UnityEngine;
using System.Collections.Generic;
using System;

public class UseNPCTextDialog : MonoBehaviour, UsableInterface
{
    public Canvas canvas;
    public List<String> dialogs;
    public KeyCode keyCode;
    bool blocked = false;
    bool initialized = false;
    int counter = 0;
    private DialogText dialogText;


    void Update()
    {
        if (initialized)
        {
            if (Input.GetKeyDown(keyCode) && !blocked)
            {
                if (counter == dialogs.Count)
                {
                    reset();
                }
                setNextDialog();
                blocked = true;
            }

            if (Input.GetKeyUp(keyCode) && blocked)
            {
                blocked = false;
                if (counter < dialogs.Count)
                {
                    counter++;
                }
                else
                {
                    reset();
                }
            }
        }  
    }


    public void Use()
    {
        if (!canvas.isActiveAndEnabled)
        {
            canvas.gameObject.SetActive(true);
            canvas.enabled = true;
            dialogText = DialogText.getInstance();
        } else
        {
            dialogText = DialogText.getInstance();
        }
        dialogText = DialogText.getInstance();
        initialized = true;
    }

    private void setNextDialog()
    {
        dialogText.setText(dialogs[counter].ToString());
    }

    private void reset()
    {
        initialized = false;
        canvas.gameObject.active = false;
        counter = 0;
        dialogText.setText("");
    }
}
