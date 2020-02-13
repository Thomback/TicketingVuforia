using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFadeOut : MonoBehaviour
{
    public Animator animButton;
    public Animator animEcran;

    public float timeBeforeAnim = 7;

    private void Update()
    {
        timeBeforeAnim -= Time.deltaTime;

        if (timeBeforeAnim <= 0)
        {
            byeByeScreen();
        }
    }

    public void byeByeScreen()
    {
        animButton.Play("ButtonByeBye");
        animEcran.Play("EcranByeBye");
    }
}
