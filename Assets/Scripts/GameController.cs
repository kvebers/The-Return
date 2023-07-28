using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    public TMP_InputField textEntryField;
    public TMP_Text logText; // Change the type to TMP_Text
    public TMP_Text currentText; // Change the type to TMP_Text

    [TextArea] public string introText;

    void Start()
    {
        logText.text = introText;
        DsiplayLocation();
        textEntryField.ActivateInputField();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DsiplayLocation()
    {
        string description = player.currentLocation.description + "\n";
        description += player.currentLocation.GetConnectionsText();
        currentText.text = description;
    }

    public void TextEntered()
    {
        LogCurrentText();
        ProcessInput(textEntryField.text);
        textEntryField.text = "";
        textEntryField.ActivateInputField();
    }

    void LogCurrentText()
    {
        logText.text += "\n\n";
        logText.text += currentText.text;

        logText.text += "\n\n";
        logText.text += "<color=#55ee55ff>" + "Your command was: "+ textEntryField.text + "</color>";
    }

    // todo process the commands (seperated words)

    void ProcessInput(string input)
    {
        input = input.ToLower();

        char[] delimiter = {' '};
        string[] seperatedWords = input.Split(delimiter);

        currentText.text = "Ei mate the spell you are using is incorrect, read the holy scroll of \"help\" for correct spells";
    }
}
