using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject nameText;
    public GameObject descText;

    private GameObject itemTargeted;
    private bool isVisible = false;

    Animator anim;

    void Start()
    {
        anim = nameText.transform.parent.parent.GetComponent<Animator>();
    }

    public void displayNewInfos(GameObject target)
    {
        if (target.GetComponent<InterractableObject>() != null)
        {
            itemTargeted = target;
            updateText();
            if (!isVisible)
            {
                anim.Play("Appearing");
                isVisible = true;
            }

        }
    }

    public void hideInfos()
    {
        if (isVisible)
        {
            anim.Play("Disappearing");
            isVisible = false;
        }
    }


    public void updateText()
    {
        nameText.GetComponent<TMPro.TextMeshProUGUI>().text
            = itemTargeted.GetComponent<InterractableObject>().name;
        descText.GetComponent<TMPro.TextMeshProUGUI>().text
            = itemTargeted.GetComponent<InterractableObject>().description;
    }
}