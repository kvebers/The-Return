using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Help")]
public class Help : Action
{
    public override void RespondToInput(GameController controller, string verb)
    {
        controller.currentText.text = "Type a Verb followed by a noun (example: \"go north\"";
        controller.currentText.text += "\nAllowed verbs:\n Go, Examine, Get, Use, Inventory, TalkTo, Say, Help";
    }
}
