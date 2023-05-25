using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class TheGameManager : MonoBehaviour
{
    public static bool openDoor = false;
    public GameObject enterStoreUI;
    public static int Money = 1000;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enterStoreUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(openDoor == true)
        {
            enterStoreUI.SetActive(true);
        }
        else
        {
            enterStoreUI.SetActive(false);
        }
    }

    public void YesEnterStore()
    {
        openDoor = false;
        EditorSceneManager.LoadScene("Store");
    }

    public void NoEnterStore()
    {
        openDoor = false;
    }


}
