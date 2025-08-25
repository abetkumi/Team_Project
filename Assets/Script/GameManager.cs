using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //�Q�[���̏��
    public enum GameState
    {
        enGameState_Play,
        enGameState_Clear,
    }
    static GameState m_gameState = GameState.enGameState_Play;

    public void SetGameState(GameState gameState)
    {
        m_gameState = gameState;
    }
    //�ǂ�����ł��Ăяo����֐�
    public static GameState GetGameState()
    {
        return m_gameState;
    }

    // Start is called before the first frame update
    void Start()
    {
        //�X�e�[�g�̍X�V�i�������j
        m_gameState = GameState.enGameState_Play;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
