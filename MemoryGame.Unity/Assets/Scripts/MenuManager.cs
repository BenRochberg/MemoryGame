using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject ezteLogo, menuPanel;
    public Button playBtn, quitBtn;
    public float completeTime;
    public float delayTime;
    void Start()
    {
        LeanTween.alpha(ezteLogo.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(menuPanel.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(playBtn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(quitBtn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
    }
    public void PlayClicked()
    {
        playBtn.interactable = false;
        quitBtn.interactable = false;
        LeanTween.alpha(playBtn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(quitBtn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(ezteLogo.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(menuPanel.GetComponent<RectTransform>(), 0f, completeTime).setOnComplete(NextLevel);
    }
    void NextLevel() => SceneManager.LoadScene("GameScene");
    public void QuitGame() => Application.Quit();

}