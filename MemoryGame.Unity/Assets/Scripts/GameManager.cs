using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Sprite bgImage;

    public Sprite[] puzzles;

    public List<Button> btns = new List<Button>();

    public List<Sprite> gamePuzzles = new List<Sprite>();

    public GameObject finishedPanel;

    private bool firstGuess, secondGuess;

    private int countGuesses;
    private int countCorrectGuesses;
    private int gameGuesses;

    private int firstGuessIndex, secondGuessIndex;

    private string firstGuessPuzzle, secondGuessPuzzle;

    private void Awake()  //This function loads each image in the "Level1Sprites" folder as a puzzle (card).
    {
        puzzles = Resources.LoadAll<Sprite>("Level1Sprites");
    }
    private void Start()
    {
        GetButtons();
        AddListeners();
        AddGamePuzzles();
        Shuffle(gamePuzzles);
        gameGuesses = gamePuzzles.Count / 2;
        finishedPanel.SetActive(false);
    }

    void GetButtons()  //Each Card has the tag "PuzzleButton" and when the buttons spawn in, they use a blank card image. The LeanTween line is a fading in animation.
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for(int i = 0; i < objects.Length; i++)
        {
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = bgImage;
            LeanTween.alpha(btns[i].GetComponent<RectTransform>(), 1f, 0.5f).setDelay(0.5f);
        }
    }

    void AddGamePuzzles()
    {
        int looper = btns.Count;
        int index = 0;

        for (int i = 0; i < looper; i++)
        {
            if (index == looper / 2)
            {
                index = 0;
            }
            gamePuzzles.Add(puzzles[index]);
            index++;
        }
    }

    void AddListeners()  //Checks when a card is clicked
    {
        foreach (Button btn in btns)
        {
            btn.onClick.AddListener(() => PickAPuzzle());
        }
    }

    public void PickAPuzzle()  //Picking you first card sets the firstGuess bool to true, sets it as the currentSelectedGameObject, and changes the blank image to the image it pulled from the folder. Same with the second Guess.
    {        
        if (!firstGuess)
        {
            firstGuess = true;
            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;
            btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
        }
        else if (!secondGuess)
        {
            secondGuess = true;
            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;
            btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];

            countGuesses++;

            StartCoroutine(CheckIfThePuzzlesMatch());
        }
    }

    IEnumerator CheckIfThePuzzlesMatch()  //If the cards have the same image, set both cards interactability and fade them out.
    {
        yield return new WaitForSeconds(1f);

        if (firstGuessPuzzle == secondGuessPuzzle)
        {
            yield return new WaitForSeconds(0.2f);

            btns[firstGuessIndex].interactable = false;
            btns[secondGuessIndex].interactable = false;

            LeanTween.alpha(btns[firstGuessIndex].GetComponent<RectTransform>(), 0f, 0.5f);
            LeanTween.alpha(btns[secondGuessIndex].GetComponent<RectTransform>(), 0f, 0.5f);

            CheckIfTheGameIsFinished();
        }
        else  //If the card don't have the same image, change the images of the cards back to the blank card image.
        {
            yield return new WaitForSeconds(0.5f);
            btns[firstGuessIndex].image.sprite = bgImage;
            btns[secondGuessIndex].image.sprite = bgImage;
        }

        yield return new WaitForSeconds(0.5f);
        firstGuess = secondGuess = false;
    }

    void CheckIfTheGameIsFinished()  //If the game is finished, set the finishedPanel to true and slide it in from the bottom.
    {
        countCorrectGuesses++;
        
        if (countCorrectGuesses == gameGuesses)
        {
            Debug.Log("Game Finished!");
            Debug.Log("It took you " + countGuesses + " many guess(es) to finish the game!");
            finishedPanel.SetActive(true);
            LeanTween.moveLocalY(finishedPanel, 0f, 1f).setDelay(0.5f).setEase(LeanTweenType.easeOutQuart);
        }
    }

    void Shuffle(List<Sprite> list)  //When the cards spawn in, it will randomly shuffle where each card is every game.
    {
        for (int i = 0; i < list.Count; i++)
        {
            Sprite temp = list[i];
            int randomIndex = Random.Range(0, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

    public void ReturnClicked()  //If the Return to Main Menu Button is clicked, lower the Alpha of the finishedPanel to 0 and load the MainMenu scene.
    {
        LeanTween.alpha(finishedPanel.GetComponent<RectTransform>(), 0f, 1f).setOnComplete(ReturnToMenu);
    }

    void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
