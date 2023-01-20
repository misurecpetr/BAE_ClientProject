using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public void whenColorPicked(GameObject colorToShow)
    {
        colorToShow.SetActive(true);
    }
}
