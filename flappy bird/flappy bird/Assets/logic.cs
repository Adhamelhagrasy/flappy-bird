using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public int playerscore;
    public Text text;
    public GameObject gameoverscreen;
    [ContextMenu("increase")]
    public void addscore()
    {
        playerscore = playerscore+1;
        text.text=playerscore.ToString();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }
}

