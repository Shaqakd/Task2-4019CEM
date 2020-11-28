using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BodyPartChanger : MonoBehaviour
{
    //Which sprite will be changed
    public SpriteRenderer bodyPart;
    //What list of sprites to change
    public List<Sprite> Sprites = new List<Sprite>();
    private int currentSprite = 0;
    
    public void SetSprite(int Num)
    {
        //Takes a integer value and updates the sprite array
        if (Num > Sprites.Count)
            return; 
        
        currentSprite = Num;
        bodyPart.sprite = Sprites[currentSprite];
    }

    public void NextSprite()
    {
        //Will index once to the next value
        currentSprite++;
        if (currentSprite >= Sprites.Count)
        {
            currentSprite = 0;
            //Resets the counter when all items in list have been cycled through
        }
        bodyPart.sprite = Sprites[currentSprite];
    }
    public void PreviousSprite()
    {
        //Will index once the previous value
        currentSprite--;
        if (currentSprite < 0)
        {
            currentSprite = Sprites.Count - 1;
            //Rests when all objects in list have been cycled through
        }
        bodyPart.sprite = Sprites[currentSprite];
    }
    public void Randomizer()
    {
        //Randomizes the Sprite index
        currentSprite = Random.Range(0, Sprites.Count - 1);
        bodyPart.sprite = Sprites[currentSprite];
    }

}
