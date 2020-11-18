using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField]
    public InputField playerValueField;
    private TweenAnimation m_tweenAnimation;
    private int m_PlayerValue = 0;
    private int m_valueGame = 0;

    private void Awake()
    {
        m_tweenAnimation = FindObjectOfType<TweenAnimation>();
    }
    void Start()
    
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_PlayerValue = (int.Parse(playerValueField.text));

            if (m_PlayerValue < m_valueGame)
            {
                Debug.Log("C'est plus");
                StartCoroutine(m_tweenAnimation.More());
            }
            if (m_PlayerValue > m_valueGame)
            {
                Debug.Log("C'est moins");
                StartCoroutine(m_tweenAnimation.Less());
            }
            if(m_PlayerValue == m_valueGame)
            {
                Debug.Log("C'est ça !! GG");
                m_tweenAnimation.Win();
            }
            if (playerValueField.text == null)
            {
                Debug.Log("Entre une valeur, Boloss");
            }
        }

        
       
        
    }

    public void CreateValue()
    {
        m_valueGame = Random.Range(1, 101);
        Debug.Log(m_valueGame);
    }

    public void Validate()
    {
        m_PlayerValue = (int.Parse(playerValueField.text));

        if (m_PlayerValue < m_valueGame)
        {
            Debug.Log("C'est plus");
            StartCoroutine(m_tweenAnimation.More());
        }
        if (m_PlayerValue > m_valueGame)
        {
            Debug.Log("C'est moins");
            StartCoroutine(m_tweenAnimation.Less());
        }
        if (m_PlayerValue == m_valueGame)
        {
            Debug.Log("C'est ça !! GG");
            m_tweenAnimation.Win();
        }
        if (playerValueField.text == null)
        {
            Debug.Log("Entre une valeur, Boloss");
        }
    }



}

