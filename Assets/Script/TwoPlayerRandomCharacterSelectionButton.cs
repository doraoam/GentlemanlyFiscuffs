﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TwoPlayerRandomCharacterSelectionButton : MonoBehaviour
{
    public void onClickRandom()
    {
        if (TwoPlayerNextButtonCharacterSelection.enablePlayer1 != TwoPlayerNextButtonCharacterSelection.enablePlayer2)
        {
            string player1Name;
            string player2Name;

            Sprite sprite;
            Sprite sprite2;

            Sprite[] images = Resources.LoadAll<Sprite>("DC/");
            sprite = images[Random.Range(0, images.Length)];

            Image Image = transform.Find("Player1/playerImage").GetComponent<Image>();
            Image.sprite = sprite;

            player1Name = findName(sprite.name);

            Text text = transform.Find("Player1/Player1Text").GetComponent<Text>();
            text.text = player1Name;

            Sprite[] images2 = Resources.LoadAll<Sprite>("DC/");

            // if create a new Sprite variable here will found unlimit loop.
            sprite2 = images[Random.Range(0, images.Length)];

            Image Image2 = transform.Find("Player2/playerImage").GetComponent<Image>();
            Image2.sprite = sprite2;

            player2Name = findName(sprite2.name);

            Text text2 = transform.Find("Player2/Player2Text").GetComponent<Text>();
            text2.text = player2Name;

            TwoPlayerNextButtonCharacterSelection.enablePlayer1 = false;
            TwoPlayerNextButtonCharacterSelection.enablePlayer2 = false;

            StartCoroutine(nextStage());
        }
    }

    string findName(string name)
    {
        string nickname;

        if (name == "Batman-SUMPC")
        {
            nickname = "Batman";
        }
        else if (name == "Robin-SUMPC")
        {
            nickname = "Robin";
        }
        else if (name == "Maxwell")
        {
            nickname = "Maxwell";
        }
        else if (name == "Superman-SUMPC")
        {
            nickname = "Superman";
        }
        else if (name == "Green_Lantern_Hal_Jordan")
        {
            nickname = "Green Lantern";
        }
        else if (name == "Andrew_Warthen")
        {
            nickname = "Jeve Stob";
        }
        else if (name == "Joker_DC")
        {
            nickname = "Joker";
        }
        else if (name == "Villain_Female")
        {
            nickname = "Penguin";
        }
        else if (name == "Nathan_Hernandez_SnU")
        {
            nickname = "Storm trooper";
        }
        else if (name == "Brady_Houck")
        {
            nickname = "Brady";
        }
        else if (name == "Knight_(Male)")
        {
            nickname = "Knight";
        }
        else if (name == "Sandman")
        {
            nickname = "Sandman";
        }
        else
        {
            nickname = "Let's guess!";
        }

        return nickname;
    }

    IEnumerator nextStage()
    {
        yield return new WaitForSeconds(3);

        Application.LoadLevel("TwoPlayerStage");
    }
}
