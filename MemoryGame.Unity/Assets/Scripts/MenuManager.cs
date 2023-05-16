using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject ezteLogo, menuPanel;
    public Button play1Btn;
    public float completeTime;
    public float delayTime;
    void Start()  //Each GameObject and Button in the Main Menu start off at 0 alpha. On Start, these 4 lines turn up the alpha to 255 (0f = 0 Alpha, 1f = 255 Alpha). There are floats to change how fast the Alpha changes (completeTime) and how long it waits to start the animation (delayTime).
    {
        LeanTween.alpha(ezteLogo.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(menuPanel.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(play1Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        //LeanTween.alpha(quitBtn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
    }
    public void PlayClicked()  //When you click on the Play Button on the Main Menu, it sets both Buttons' interability to false and turns down each GameObject and Buttons Alpha to 0. The setOnComplete function sends the player to the second scene (GameScene) once the animations complete.
    {
        play1Btn.interactable = false;
        //quitBtn.interactable = false;
        LeanTween.alpha(play1Btn.GetComponent<RectTransform>(), 0f, completeTime);
        //LeanTween.alpha(quitBtn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(ezteLogo.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(menuPanel.GetComponent<RectTransform>(), 0f, completeTime).setOnComplete(GoToLevel);
    }
    void GoToLevel() => SceneManager.LoadScene("LevelSelect");
    //public void QuitGame() => Application.Quit();

}