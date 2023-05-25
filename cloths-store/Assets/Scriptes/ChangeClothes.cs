using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeClothes : MonoBehaviour
{
    public GameObject clothesOptions;
    public GameObject colorsOptions;
    public Sprite[] shirts;
    public Sprite[] pants;
    public Sprite[] shoes;

    public static Sprite myShirts;
    public static Sprite myPants;
    public static Sprite myShoes;
    public GameObject player;

    bool isShirt = false;
    bool isPants = false;
    bool isShoes = false;
    public static bool doneShopping = false;
    bool Picked = false;
    public int[] prices;

    public static bool outfitOn = false;
    // Start is called before the first frame update
    void Start()
    {
        clothesOptions.SetActive(true);
        colorsOptions.SetActive(false);
    }

    void Update()
    {
        if (myPants != null || myShirts != null || myShoes != null)
            outfitOn = true;
    }

    // Update is called once per frame
    public void OnClickShirts()
    {
        clothesOptions.SetActive(false);
        colorsOptions.SetActive(true);
        isShirt = true;

        for(int i=0;i<shirts.Length;i++)
        {
            colorsOptions.transform.GetChild(i).GetComponent<Button>().image.sprite = shirts[i];
        }
    }

    public void OnCLickPants()
    {
        clothesOptions.SetActive(false);
        colorsOptions.SetActive(true);
        isPants = true;

        for (int i = 0; i < pants.Length; i++)
        {
            colorsOptions.transform.GetChild(i).GetComponent<Button>().image.sprite = pants[i];
        }
    }

    public void OnClickShoes()
    {
        clothesOptions.SetActive(false);
        colorsOptions.SetActive(true);
        isShoes = true;

        for (int i = 0; i < shoes.Length; i++)
        {
            colorsOptions.transform.GetChild(i).GetComponent<Button>().image.sprite = shoes[i];
        }
    }

    public void OnClickFirst()
    {
        ChangePlayerClothes(0);
        Picked = true;
    }

    public void OnClickSecond()
    {
        ChangePlayerClothes(1);
        Picked = true;
    }

    public void OnClickThird()
    {
        ChangePlayerClothes(2);
        Picked = true;
    }

    public void ChangePlayerClothes(int choice)
    {
        if(isShirt)
        {
            foreach(Transform part in player.transform)
            {
                if(part.name == "Shirt")
                {
                    part.gameObject.SetActive(true);
                    part.GetComponent<SpriteRenderer>().sprite = shirts[choice];
                }
            }
        }

        else if(isPants)
        {
            foreach (Transform part in player.transform)
            {
                if (part.name == "Pants")
                {
                    part.gameObject.SetActive(true);
                    part.GetComponent<SpriteRenderer>().sprite = pants[choice];
                }
            }
        }

        else if(isShoes)
        {
            foreach (Transform part in player.transform)
            {
                if (part.name == "Shoes")
                {
                    part.gameObject.SetActive(true);
                    part.GetComponent<SpriteRenderer>().sprite = shoes[choice];
                }
            }
        }
    }

    public void OnBackToClothes()
    {
        isShirt = false;
        isPants = false;
        isShoes = false;
        Picked = false;
        clothesOptions.SetActive(true);
        colorsOptions.SetActive(false);
    }

    public void OnPurchase()
    {
        if(Picked)
        {
            foreach (Transform part in player.transform)
            {
                if (part.name == "Shirt" && isShirt && part.gameObject.activeSelf)
                {
                    if(TheGameManager.Money - prices[0] >= 0)
                    {
                        myShirts = part.GetComponent<SpriteRenderer>().sprite;
                        TheGameManager.Money = TheGameManager.Money - prices[0];
                    }
                }

                else if (part.name == "Pants" && isPants && part.gameObject.activeSelf)
                {
                    if (TheGameManager.Money - prices[1] >= 0)
                    {
                        myPants = part.GetComponent<SpriteRenderer>().sprite;
                        TheGameManager.Money = TheGameManager.Money - prices[1];
                    }
                        
                }

                else if (part.name == "Shoes" && isShoes && part.gameObject.activeSelf)
                {
                    if (TheGameManager.Money - prices[2] >= 0)
                    {
                        myShoes = part.GetComponent<SpriteRenderer>().sprite;
                        TheGameManager.Money = TheGameManager.Money - prices[2];
                    }
                        
                }
            }
            OnBackToClothes();
        }
        
    }

    public void OnRestRoom()
    {
        foreach (Transform part in player.transform)
        {
            if (part.name == "Shirt" || part.name == "Pants" || part.name == "Shoes")
                part.gameObject.SetActive(false);
        }
    }
    
}
