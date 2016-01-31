using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogText : MonoBehaviour {

    static DialogText instance;
    Text textLabel;

    void Awake()
    {
        instance = this;
        textLabel = GetComponent<Text>();
    }

	public static DialogText getInstance()
    {
        return instance;
    }

    public void setText(string newText)
    {
        textLabel.text = newText;
    }
}
