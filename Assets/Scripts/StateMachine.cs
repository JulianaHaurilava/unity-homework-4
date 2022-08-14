using UnityEngine;

public class StateMachine : MonoBehaviour
{

    [SerializeField] private GameObject calculatorScreen;
    [SerializeField] private GameObject compareScreen;
    private GameObject currentScreen;

    void Start()
    {
        calculatorScreen.SetActive(true);
        currentScreen = calculatorScreen;
    }

    public void ChangeState(GameObject screen)
    {
        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            screen.SetActive(true);
            currentScreen = screen;
        }
    }
}
