using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelQuizManager : MonoBehaviour
{
    [System.Serializable]
    public class PanelQuestion
    {
        public GameObject panel;
        public bool isTrue;
    }

    public List<PanelQuestion> panelQuestions;
    public Button trueButton;
    public Button falseButton;
    public GameObject resultPanelCorrect;
    public GameObject resultPanelIncorrect;

    private int currentPanelIndex = 0;
    private int correctAnswers = 0;
    private int wrongAnswers = 0;

    void Start()
    {
        trueButton.onClick.AddListener(() => Answer(true));
        falseButton.onClick.AddListener(() => Answer(false));

        ShowPanel(currentPanelIndex);

        if (resultPanelCorrect != null)
        {
            resultPanelCorrect.SetActive(false);
        }
        if (resultPanelIncorrect != null)
        {
            resultPanelIncorrect.SetActive(false);
        }
    }

    void ShowPanel(int index)
    {
        // Alle Panels deaktivieren
        foreach (var panelQuestion in panelQuestions)
        {
            panelQuestion.panel.SetActive(false);
        }

        // Das aktuelle Panel aktivieren
        if (index < panelQuestions.Count)
        {
            panelQuestions[index].panel.SetActive(true);
        }
    }

    void Answer(bool userAnswer)
    {
        if (currentPanelIndex < panelQuestions.Count)
        {
            if (panelQuestions[currentPanelIndex].isTrue == userAnswer)
            {
                correctAnswers++;
            }
            else
            {
                wrongAnswers++;
            }

            currentPanelIndex++;

            if (currentPanelIndex < panelQuestions.Count)
            {
                ShowPanel(currentPanelIndex);
            }
            else
            {
                ShowResult();
            }
        }
    }

    void ShowResult()
    {
        foreach (var panelQuestion in panelQuestions)
        {
            panelQuestion.panel.SetActive(false);
        }

        if (wrongAnswers == 0 && resultPanelCorrect != null)
        {
            resultPanelCorrect.SetActive(true);
        }
        else if (wrongAnswers > 0 && resultPanelIncorrect != null)
        {
            resultPanelIncorrect.SetActive(true);
        }

        trueButton.gameObject.SetActive(false);
        falseButton.gameObject.SetActive(false);
    }

}
