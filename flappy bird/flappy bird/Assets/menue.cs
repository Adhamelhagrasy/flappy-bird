using UnityEngine;
using UnityEngine.SceneManagement;

public class menue : MonoBehaviour
{
  public void startclick()
    {
        SceneManager.LoadScene("SampleScene");
    }
   public void exitclick()
    {
#if UNITY_EDITOR 
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
