using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButtons : MonoBehaviour
{

    [SerializeField] private Transform puzzleField;

    [SerializeField] private GameObject btn;

    private void Awake()  //When this script is awoken, it will spawn in the specified amount of cards. In this case, it will spawn 20 cards.
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(puzzleField, false);
        }



    }
}
