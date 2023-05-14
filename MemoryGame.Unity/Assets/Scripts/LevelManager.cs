using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject levelSelectPanel, firstLevelsPanel, level1Holder, level2Holder, level3Holder, level4Holder, level5Holder;
    public Button level1Btn, level2Btn, level3Btn, level4Btn, level5Btn, backBtn;
    public float completeTime;
    public float bounceTime;
    public float delayTime;
    void Start()
    {
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(firstLevelsPanel.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(level1Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(level2Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(level3Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(level4Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(level5Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(backBtn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.scale(level1Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level2Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level3Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level4Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level5Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
    }

    void SetUpForNextLevel()
    {
        level1Btn.interactable = false;
        level2Btn.interactable = false;
        backBtn.interactable = false;
        LeanTween.scale(level1Holder, new Vector2(0f, 0f), bounceTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level2Holder, new Vector2(0f, 0f), bounceTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level3Holder, new Vector2(0f, 0f), bounceTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level4Holder, new Vector2(0f, 0f), bounceTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level5Holder, new Vector2(0f, 0f), bounceTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.alpha(level1Btn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(level2Btn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(level3Btn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(level4Btn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(level5Btn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(backBtn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(firstLevelsPanel.GetComponent<RectTransform>(), 0f, completeTime);
    }
    public void PlayOneClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime).setDelay(0.5f).setOnComplete(GoToOne);
    }

    public void PlayTwoClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime).setDelay(0.5f).setOnComplete(GoToTwo);
    }
    public void PlayThreeClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime).setDelay(0.5f).setOnComplete(GoToThree);
    }
    public void PlayFourClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime).setDelay(0.5f).setOnComplete(GoToFour);
    }
    public void PlayFiveClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime).setDelay(0.5f).setOnComplete(GoToFive);
    }
    public void Back()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime).setOnComplete(GoToMenu);
    }
    void GoToOne() => SceneManager.LoadScene("GameScene1");
    void GoToTwo() => SceneManager.LoadScene("GameScene2");
    void GoToThree() => SceneManager.LoadScene("GameScene3");
    void GoToFour() => SceneManager.LoadScene("GameScene4");
    void GoToFive() => SceneManager.LoadScene("GameScene5");
    void GoToMenu() => SceneManager.LoadScene("MainMenu");
}
