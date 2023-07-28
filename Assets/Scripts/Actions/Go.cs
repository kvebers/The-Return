using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Go")]
public class Go : Action
{
    public override void RespondToInput(GameController controller, string verb)
    {
        if (controller.player.ChangeLocation(controller, verb) == true)
        {
            controller.DsiplayLocation();
        }
        else
        {
            controller.currentText.text = "You can't go that way";
        }
    }
}
