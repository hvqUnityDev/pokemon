using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    private PokemonBase _base;
    private int level;

    public int HP { get; set; }
    public List<Move> Moves { get; set; }
    
    public Pokemon(PokemonBase pBase, int level)
    {
        _base = pBase;
        this.level = level;
        HP = _base.MaxHP;
        
        Moves = new List<Move>();
        foreach (var move in _base.LearnableMoves)
        {
            if (move.Level <= level)
            {
                Moves.Add(new Move(move.Base));
            }
            if (Moves.Count >= 4)
            {
                break;
            }
        }
    }

    public int Attack
    {
        get { return Mathf.FloorToInt((_base.Attack * level) / 100f) + 5; } 
    }
    
    public int MaxHP
    {
        get { return Mathf.FloorToInt((_base.MaxHP * level) / 100f) + 5; } 
    }
    
    public int Defense
    {
        get { return Mathf.FloorToInt((_base.Defense * level) / 100f) + 5; } 
    }
    
    public int SpAttack
    {
        get { return Mathf.FloorToInt((_base.SpAttack * level) / 100f) + 5; } 
    }
    
    public int SpDesfense
    {
        get { return Mathf.FloorToInt((_base.SpDesfense * level) / 100f) + 5; }
    }
    
    public int Speed
    {
        get { return Mathf.FloorToInt((_base.Speed * level) / 100f) + 5; }
    }
    
    
    
    
}
