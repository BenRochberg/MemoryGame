using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject levelSelectPanel, firstLevelsPanel, secondLevelsPanel, thirdLevelsPanel, level1Holder, level2Holder, level3Holder, level4Holder, level5Holder, level6Holder, level7Holder, level8Holder, level9Holder, level10Holder, level11Holder, level12Holder;
    public Button level1Btn, level2Btn, level3Btn, level4Btn, level5Btn, level6Btn, level7Btn, level8Btn, level9Btn, level10Btn, level11Btn, level12Btn, backBtn;
    public float completeTime;
    public float bounceTime;
    public float groupOneDelayTime;
    public float groupTwoDelayTime;
    public float groupThreeDelayTime;
    public float SetUpTime;
    void Start()
    {
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.alpha(firstLevelsPanel.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.alpha(secondLevelsPanel.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupTwoDelayTime);
        LeanTween.alpha(thirdLevelsPanel.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupThreeDelayTime);
        LeanTween.alpha(level1Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.alpha(level2Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.alpha(level3Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.alpha(level4Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.alpha(level5Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupTwoDelayTime);
        LeanTween.alpha(level6Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupTwoDelayTime);
        LeanTween.alpha(level7Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupTwoDelayTime);
        LeanTween.alpha(level8Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupTwoDelayTime);
        LeanTween.alpha(level9Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupThreeDelayTime);
        LeanTween.alpha(level10Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupThreeDelayTime);
        LeanTween.alpha(level11Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupThreeDelayTime);
        LeanTween.alpha(level12Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupThreeDelayTime);
        LeanTween.alpha(backBtn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.scale(level1Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level2Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level3Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level4Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level5Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level6Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level7Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level8Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level9Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level10Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level11Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level12Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
    }

    void SetUpForNextLevel()
    {
        level1Btn.interactable = false;
        level2Btn.interactable = false;
        level3Btn.interactable = false;
        level4Btn.interactable = false;
        level5Btn.interactable = false;
        level6Btn.interactable = false;
        level7Btn.interactable = false;
        level8Btn.interactable = false;
        level9Btn.interactable = false;
        level10Btn.interactable = false;
        level11Btn.interactable = false;
        level12Btn.interactable = false;
        backBtn.interactable = false;
        LeanTween.scale(level1Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupOneDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level2Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupOneDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level3Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupOneDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level4Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupOneDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level5Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupTwoDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level6Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupTwoDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level7Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupTwoDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level8Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupTwoDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level9Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupThreeDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level10Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupThreeDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level11Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupThreeDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level12Holder, new Vector2(0f, 0f), bounceTime).setDelay(groupThreeDelayTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.alpha(level1Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.alpha(level2Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.alpha(level3Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.alpha(level4Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.alpha(level5Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupTwoDelayTime);
        LeanTween.alpha(level6Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupTwoDelayTime);
        LeanTween.alpha(level7Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupTwoDelayTime);
        LeanTween.alpha(level8Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupTwoDelayTime);
        LeanTween.alpha(level9Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupThreeDelayTime);
        LeanTween.alpha(level10Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupThreeDelayTime);
        LeanTween.alpha(level11Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupThreeDelayTime);
        LeanTween.alpha(level12Btn.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupThreeDelayTime);
        LeanTween.alpha(backBtn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(firstLevelsPanel.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupOneDelayTime);
        LeanTween.alpha(secondLevelsPanel.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupTwoDelayTime);
        LeanTween.alpha(thirdLevelsPanel.GetComponent<RectTransform>(), 0f, completeTime).setDelay(groupThreeDelayTime);
    }
    public void PlayOneClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToOne);
    }

    public void PlayTwoClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToTwo);
    }
    public void PlayThreeClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToThree);
    }
    public void PlayFourClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToFour);
    }
    public void PlayFiveClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToFive);
    }
    public void PlaySixClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToSix);
    }
    public void PlaySevenClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToSeven);
    }

    public void PlayEightClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToEight);
    }
    public void PlayNineClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToNine);
    }
    public void PlayTenClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToTen);
    }
    public void PlayElevenClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToEleven);
    }
    public void PlayTwelveClicked()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToTwelve);
    }
    public void Back()
    {
        SetUpForNextLevel();
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime + SetUpTime).setOnComplete(GoToMenu);
    }
    void GoToOne() => SceneManager.LoadScene("GameScene1");
    void GoToTwo() => SceneManager.LoadScene("GameScene2");
    void GoToThree() => SceneManager.LoadScene("GameScene3");
    void GoToFour() => SceneManager.LoadScene("GameScene4");
    void GoToFive() => SceneManager.LoadScene("GameScene5");
    void GoToSix() => SceneManager.LoadScene("GameScene6");
    void GoToSeven() => SceneManager.LoadScene("GameScene7");
    void GoToEight() => SceneManager.LoadScene("GameScene8");
    void GoToNine() => SceneManager.LoadScene("GameScene9");
    void GoToTen() => SceneManager.LoadScene("GameScene10");
    void GoToEleven() => SceneManager.LoadScene("GameScene11");
    void GoToTwelve() => SceneManager.LoadScene("GameScene12");
    void GoToMenu() => SceneManager.LoadScene("MainMenu");
}
