using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class TheGameManager : MonoBehaviour
{
    public static bool openDoor = false;
    public GameObject enterStoreUI;

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
        EditorSceneManager.LoadScene("Store");
    }

    public void NoEnterStore()
    {
        openDoor = false;
    }


}
