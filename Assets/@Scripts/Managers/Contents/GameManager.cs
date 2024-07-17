using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class GameManager
{
    EGameState _gameState;
    public EGameState GameState
    {
        get { return _gameState; }
        set { _gameState = value; }
    }

    ECursorType _cursorType;
    public ECursorType CursorType
    {
        get { return _cursorType; }
        set 
        {
            _cursorType = value;
            OnCursorChanged?.Invoke(_cursorType);
        }
    }

    public Vector3 _clickCellPos;
    public Vector3 ClickCellPos
    {
        get { return _clickCellPos; }
        set 
        {
            _clickCellPos = value;
            OnClickCellPosChanged?.Invoke(_clickCellPos);
        }
    }

    public event Action<ECursorType> OnCursorChanged;
    public event Action<Vector3> OnClickCellPosChanged;
}
