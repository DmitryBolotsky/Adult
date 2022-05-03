using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuBehaviourScript : MonoBehaviour
{
  public GameObject MainPanal;
    public GameObject ShopPanal;
    public Button loginButton;
    public Button playButton;
    public Button shopButton;

    // Start is called before the first frame update
    void Start()
    {
        ShopPanal.SetActive(false);
        loginButton.onClick.AddListener(delegate{
            login();
        });
         shopButton.onClick.AddListener(delegate{
            shop();
        });
         playButton.onClick.AddListener(delegate{
            play();
        });
        
    }
    private void login()
    {
        SceneManager.LoadScene("AuthScene");
    }
    private void play()
    {
        ShopPanal.SetActive(false);
        MainPanal.SetActive(true);
    }
    private void shop()
    {
        MainPanal.SetActive(false);
        ShopPanal.SetActive(true);
    }
}
