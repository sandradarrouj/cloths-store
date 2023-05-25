using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public GameObject lobby;
    public GameObject room;
    public GameObject welcome;
    public GameObject leave;
    public Text moneyText;
    // Start is called before the first frame update
    void Start()
    {
        lobby.SetActive(true);
        room.SetActive(false);
        welcome.SetActive(true);
        leave.SetActive(false);
    }

    void Update()
    {
        moneyText.text = TheGameManager.Money.ToString()+"$";
    }

    public void OnClickYes()
    {
        lobby.SetActive(false);
        room.SetActive(true);
    }

    public void OnClickNo()
    {
        leave.SetActive(true);
        welcome.SetActive(false);
    }

    public void OnClickBackToCity()
    {
        EditorSceneManager.LoadScene("City");
    }
    
    public void OnBackToStore()
    {
        room.SetActive(false);
        lobby.SetActive(true);
        welcome.SetActive(true);
        leave.SetActive(false);
    }

}
