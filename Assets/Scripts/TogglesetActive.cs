using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglesetActive : MonoBehaviour
{
    public GameObject rocket;

    public void ButtonClicked()
    {
        if (rocket.activeSelf)
            rocket.SetActive(false);
        else
            rocket.SetActive(true);

    }
}
