using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateValues : MonoBehaviour
{
    public Controller controllerScript;
    private void updateValues()
    {
        controllerScript.updateText();
    }
}
