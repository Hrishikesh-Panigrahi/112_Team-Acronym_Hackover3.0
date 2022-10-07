using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int selectedlevel; // for using this vaiable in the mole.cs
    public int level; // getting the value of this variable from the game

    public void difficul(){
            selectedlevel=level;  

    }
}
