using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelQuizManager : MonoBehaviour
{
    [System.Serializable]
    public class PanelQuestion
    {
        public GameObject panel; // Das Panel, das angezeigt werden soll
        public bool isTrue; // Ob die Antwort auf diesem Panel "wahr" ist
    }

    public List<PanelQuestion> panelQuestions; // Liste der Panels und deren Antworten
    public Button trueButton; // Button für "wahr"
    public Button falseButton; // Button für "falsch"
    public GameObject resultPanelCorrect; // Panel für das Ergebnis, wenn alle Antworten korrekt sind
    public GameObject resultPanelIncorrect; // Panel für das Ergebnis, wenn es falsche Antworten gibt

    private int currentPanelIndex = 0; // Index des aktuellen Panels
    private int correctAnswers = 0; // Anzahl der richtigen Antworten
    private int wrongAnswers = 0; // Anzahl der falschen Antworten

    void Start()
    {
        // Buttons mit den Funktionen verknüpfen
        trueButton.onClick.AddListener(() => Answer(true));
        falseButton.onClick.AddListener(() => Answer(false));

        // Nur das erste Panel anzeigen
        ShowPanel(currentPanelIndex);

        // Ergebnis-Panels zu Beginn deaktivieren
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
        // Überprüfen, ob die Antwort korrekt ist
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

            // Zum nächsten Panel wechseln
            currentPanelIndex++;

            if (currentPanelIndex < panelQuestions.Count)
            {
                ShowPanel(currentPanelIndex);
            }
            else
            {
                // Wenn alle Panels durch sind, Ergebnis anzeigen
                ShowResult();
            }
        }
    }

    void ShowResult()
    {
        // Alle Panels ausblenden
        foreach (var panelQuestion in panelQuestions)
        {
            panelQuestion.panel.SetActive(false);
        }

        // Richtiges Ergebnis-Panel anzeigen basierend auf den Antworten
        if (wrongAnswers == 0 && resultPanelCorrect != null)
        {
            resultPanelCorrect.SetActive(true);
        }
        else if (wrongAnswers > 0 && resultPanelIncorrect != null)
        {
            resultPanelIncorrect.SetActive(true);
        }

        // Buttons deaktivieren
        trueButton.gameObject.SetActive(false);
        falseButton.gameObject.SetActive(false);
    }

}
