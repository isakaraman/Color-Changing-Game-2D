using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomColor : MonoBehaviour
{
    public SpriteRenderer sprt;
    public bool winCheckBool = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&!winCheckBool)
        {
            random_Colors();
        }
        
    }

    void random_Colors()
    {
        int rnd = Random.Range(1, 6);

        switch (rnd)
        {
            case 1:
                sprt.color = Color.yellow;
                break;
            case 2:
                sprt.color = Color.blue;
                break;
            case 3:
                sprt.color = Color.green;
                break;
            case 4:
                sprt.color = Color.red;
                break;
            case 5:
                sprt.color = Color.gray;
                break;
        }
    }
}
