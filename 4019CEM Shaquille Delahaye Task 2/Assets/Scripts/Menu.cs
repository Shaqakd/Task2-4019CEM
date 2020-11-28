using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Menu : MonoBehaviour
{
    public List<BodyPartChanger> bodyPartChangers = new List<BodyPartChanger>();
    public TMP_InputField CDesign;

    public void RandomizeCharacter()
    {
        // Runs through each bodypart and randomly selects one of the index sprite values
        foreach (BodyPartChanger changer in bodyPartChangers)
        {
            changer.Randomizer();
        }
    }
    public void Submit()
    {
        //fetchs each sprite name and prints the last character.
        var Head = GameObject.Find("Head").GetComponent<SpriteRenderer>().sprite.name;
        var Torso = GameObject.Find("Torso").GetComponent<SpriteRenderer>().sprite.name;
        var LArm = GameObject.Find("LeftArm").GetComponent<SpriteRenderer>().sprite.name;
        var Rarm = GameObject.Find("RightArm").GetComponent<SpriteRenderer>().sprite.name;
        var LLeg = GameObject.Find("LeftLeg").GetComponent<SpriteRenderer>().sprite.name;
        var RLeg = GameObject.Find("RightLeg").GetComponent<SpriteRenderer>().sprite.name;
        Debug.Log(Head[Head.Length - 1].ToString() + Torso[Torso.Length - 1].ToString() + LArm[LArm.Length - 1].ToString()
            + Rarm[Rarm.Length - 1].ToString() + LLeg[LLeg.Length - 1].ToString() + RLeg[RLeg.Length - 1].ToString());
    }
    public void Recreate()
    {
        //Reads the user input and Parses the string back to the index of the sprite
        if (CDesign.text.Length == 6)
        {
            for (int i = 0; i < CDesign.text.Length; i++)
            {
                int SpriteNum = int.Parse(CDesign.text[i].ToString());
                bodyPartChangers[i].SetSprite(SpriteNum-1);
            }
        }
    }
}
