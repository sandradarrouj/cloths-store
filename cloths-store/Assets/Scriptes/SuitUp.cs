using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuitUp : MonoBehaviour
{
    void Update()
    {
        if (ChangeClothes.outfitOn)
        {
            DressUp();
            ChangeClothes.outfitOn = false;
        }
    }

    void DressUp()
    {
        foreach(Transform part in gameObject.transform)
        {
            if (part.name == "Shirt" && ChangeClothes.myShirts!=null)
                part.GetComponent<SpriteRenderer>().sprite = ChangeClothes.myShirts;
            else if(part.name == "Pants" && ChangeClothes.myPants!=null)
                part.GetComponent<SpriteRenderer>().sprite = ChangeClothes.myPants;
            else if(part.name == "Shoes" && ChangeClothes.myShoes!=null)
                part.GetComponent<SpriteRenderer>().sprite = ChangeClothes.myShoes;
        }
    }

}
