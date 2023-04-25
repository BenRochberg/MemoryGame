using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject levelSelectPanel, level1Holder, level2Holder;
    public Button level1Btn, level2Btn, backBtn;
    public float completeTime;
    public float bounceTime;
    public float delayTime;
    void Start()  //Each GameObject and Button in the Main Menu start off at 0 alpha. On Start, these 4 lines turn up the alpha to 255 (0f = 0 Alpha, 1f = 255 Alpha). There are floats to change how fast the Alpha changes (completeTime) and how long it waits to start the animation (delayTime).
    {
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(level1Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(level2Btn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.alpha(backBtn.GetComponent<RectTransform>(), 1f, completeTime).setDelay(delayTime);
        LeanTween.scale(level1Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
        LeanTween.scale(level2Holder, new Vector2(1f, 1f), bounceTime).setEase(LeanTweenType.easeInQuint);
    }
    public void PlayOneClicked()  //When you click on the Play Button on the Main Menu, it sets both Buttons' interability to false and turns down each GameObject and Buttons Alpha to 0. The setOnComplete function sends the player to the second scene (GameScene) once the animations complete.
    {
        level1Btn.interactable = false;
        level2Btn.interactable = false;
        backBtn.interactable = false;
        LeanTween.scale(level1Holder, new Vector2(0f, 0f), bounceTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level2Holder, new Vector2(0f, 0f), bounceTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.alpha(level1Btn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(level2Btn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(backBtn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime).setOnComplete(GoToOne);
    }

    public void PlayTwoClicked()  //When you click on the Play Button on the Main Menu, it sets both Buttons' interability to false and turns down each GameObject and Buttons Alpha to 0. The setOnComplete function sends the player to the second scene (GameScene) once the animations complete.
    {
        level1Btn.interactable = false;
        level2Btn.interactable = false;
        backBtn.interactable = false;
        LeanTween.scale(level1Holder, new Vector2(0f, 0f), bounceTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level2Holder, new Vector2(0f, 0f), bounceTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.alpha(level1Btn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(level2Btn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(backBtn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime).setOnComplete(GoToTwo);
    }
    public void Back()
    {
        level1Btn.interactable = false;
        level2Btn.interactable = false;
        backBtn.interactable = false;
        LeanTween.scale(level1Holder, new Vector2(0f, 0f), bounceTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(level2Holder, new Vector2(0f, 0f), bounceTime).setEase(LeanTweenType.easeOutQuint);
        LeanTween.alpha(level1Btn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(level2Btn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(backBtn.GetComponent<RectTransform>(), 0f, completeTime);
        LeanTween.alpha(levelSelectPanel.GetComponent<RectTransform>(), 0f, completeTime).setOnComplete(GoToMenu);
    }
    void GoToOne() => SceneManager.LoadScene("GameScene1");
    void GoToTwo() => SceneManager.LoadScene("GameScene2");
    void GoToMenu() => SceneManager.LoadScene("MainMenu");
}