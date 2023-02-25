using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    public static int Cantidad = 0;
    public TextMeshProUGUI score;
    public void Update()
    {
        score.text = Cantidad.ToString();
        print(Cantidad);

    }
}
