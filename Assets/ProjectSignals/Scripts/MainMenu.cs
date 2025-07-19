using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject CreditsMenu;
    public GameObject Main;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene("OtherSceneName"); // Replace this with updated name when created
        Debug.Log("This would open the game.");
    }

    public void CreditsOpen()
    {
        Main.SetActive(false);
        CreditsMenu.SetActive(true);
    }

    public void CreditsClose()
    {
        Main.SetActive(!Main.activeSelf);
        CreditsMenu.SetActive(!CreditsMenu.activeSelf);
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("This would quit the game.");
    }
}
