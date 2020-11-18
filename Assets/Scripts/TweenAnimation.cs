using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TweenAnimation : MonoBehaviour
{
    [SerializeField]
    private RectTransform m_ButtonPlay, m_ButtonQuit, m_PlayerValueField, m_MoreText, m_LessText, m_Title, m_TutoText, m_ButtonReturnMenu, m_ButtonValidate, m_WinText;
    private Game m_Game;

    private void Awake()
    {
        m_Game = FindObjectOfType<Game>();
    }
    void Start()
    {
        
    }
    private void Update()
    {
        
    }
    public void Play()
    {
        m_ButtonPlay.DOAnchorPos(new Vector2(500, -105), 0.25f);
        m_ButtonQuit.DOAnchorPos(new Vector2(-500, -150), 0.25f);
        m_PlayerValueField.DOAnchorPos(new Vector2(0, -30), 0.25f);
        m_Title.DOAnchorPos(new Vector2(0, -350), 0.25f);
        m_TutoText.DOAnchorPos(new Vector2(0, 20),0.25f);
        m_ButtonValidate.DOAnchorPos(new Vector2(0, -105), 0.25f);
        m_ButtonReturnMenu.DOAnchorPos(new Vector2(0, -150), 0.25f);
        m_Game.CreateValue();

    }
    
    public IEnumerator Less()
    {
        m_LessText.DOAnchorPos(new Vector2(-200, -110), 0.25f);
        yield return new WaitForSeconds(1f);
        m_LessText.DOAnchorPos(new Vector2(-500, -110), 0.25f);
    }
    public IEnumerator More()
    {
        m_MoreText.DOAnchorPos(new Vector2(200, -110), 0.25f);
        yield return new WaitForSeconds(1f);
        m_MoreText.DOAnchorPos(new Vector2(500, -110), 0.25f);
        
            


    }
    public void Validate()
    {
        
    }
    public void ReturnMenu()
    {
        m_ButtonPlay.DOAnchorPos(new Vector2(0, -105), 0.25f);
        m_ButtonQuit.DOAnchorPos(new Vector2(0, -150), 0.25f);
        m_ButtonValidate.DOAnchorPos(new Vector2(-500, -105), 0.25f);
        m_ButtonReturnMenu.DOAnchorPos(new Vector2(500, -150), 0.25f);
        m_TutoText.DOAnchorPos(new Vector2(0, 300), 0.25f);
        m_Title.DOAnchorPos(new Vector2(0, 45), 0.25f);
        m_PlayerValueField.DOAnchorPos(new Vector2(0, 250), 0.25f);
        m_WinText.DOAnchorPos(new Vector2(0, 400), 0.25f);

    }

    public void Win()
    {
        m_TutoText.DOAnchorPos(new Vector2(0, 300), 0.25f);
        m_PlayerValueField.DOAnchorPos(new Vector2(0, 250), 0.25f);
        m_ButtonValidate.DOAnchorPos(new Vector2(-500, -105), 0.25f);
        m_WinText.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }



}
