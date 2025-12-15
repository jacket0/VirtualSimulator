using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private const string OperatorSceneName = "OperatorScene";
    private const string MenuSceneName = "MainMenu";

    [SerializeField] private TMP_InputField _login;
    [SerializeField] private TMP_InputField _password;

    public void StartOperatorScene()
    {
        if (_login.text == "operator" && _password.text == "123")
        {
            SceneManager.LoadScene(OperatorSceneName);
        }
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(MenuSceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
