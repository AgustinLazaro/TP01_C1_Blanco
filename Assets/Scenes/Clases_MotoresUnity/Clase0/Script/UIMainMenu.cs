using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("Reference")]

    [SerializeField] private GameObject PanelPause;

    [SerializeField] private Button Play;
    [SerializeField] private Button Options;
    [SerializeField] private Button Credits;
    [SerializeField] private Button Exit;
    [SerializeField] private Button CreditsBack;

    [SerializeField] private GameObject PanelCredits;

    private bool isPause = true;

    private void Awake()
    {
        Play.onClick.AddListener(OnPlayClicked);
        Options.onClick.AddListener(OnOptionsClicked);
        Credits.onClick.AddListener(OnCreditsClicked);
        Exit.onClick.AddListener(OnExitlicked);
        CreditsBack.onClick.AddListener(OnCreditsBacklicked);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;
            PanelPause.SetActive(isPause);
            if (isPause)
              Time.timeScale = 0;
            else
                Time.timeScale = 1;
        }
    }


    private void OnDestroy()
    {
        Play.onClick.RemoveAllListeners();
        Options.onClick.RemoveAllListeners();
        Credits.onClick.RemoveAllListeners();
        Exit.onClick.RemoveAllListeners();
        CreditsBack.onClick.RemoveAllListeners();
    }

    private void OnPlayClicked()
    {
        PanelPause.SetActive(false);

    }
    private void OnOptionsClicked()
    {
        
    }
    private void OnCreditsClicked()
    {
        PanelCredits.SetActive(true);
    }
    private void OnExitlicked()
    {
       
    }
    private void OnCreditsBacklicked()
    {
        PanelCredits.SetActive(false);
    }





}