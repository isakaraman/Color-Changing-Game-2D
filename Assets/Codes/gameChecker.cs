using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameChecker : MonoBehaviour
{
    public SpriteRenderer[] sprts;
    public Text winText;
    public randomColor[] randomColorScrpt;
    public AudioSource sounds;
    public Button btn;
    void Update()
    {
        if (sprts[0].color==sprts[1].color)
        {
            winText.text = "Same Colors You Win!";

            randomColorScrpt[0].winCheckBool = true;
            randomColorScrpt[1].winCheckBool = true;

            btn.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space)&& randomColorScrpt[0].winCheckBool==false)
        {
            sounds.Play();
        }

    }
    public void buttonCheck()
    {
        SceneManager.LoadScene(0);
        
    }
}
