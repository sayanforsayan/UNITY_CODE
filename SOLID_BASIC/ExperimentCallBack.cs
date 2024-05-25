using System;
using UnityEngine;
public class ExperimentCallBack
{
    public static event Action P1_Right = delegate { };
    public static event Action P1_Left = delegate { };
    public static event Action P1_Up = delegate { };
    public static event Action P1_Down = delegate { };

    public static event Action P2_Right = delegate { };
    public static event Action P2_Left = delegate { };
    public static event Action P2_Up = delegate { };
    public static event Action P2_Down = delegate { };

    public static event Action P3_Right = delegate { };
    public static event Action P3_Left = delegate { };
    public static event Action P3_Up = delegate { };
    public static event Action P3_Down = delegate { };

    public static event Action P4_Right = delegate { };
    public static event Action P4_Left = delegate { };
    public static event Action P4_Up = delegate { };
    public static event Action P4_Down = delegate { };

    public void RoundOne()
    {
        P1_Right();
        P2_Down();
        P3_Left();
        P4_Up();
    }

    public void RoundTwo()
    {
        P1_Down();
        P2_Left();
        P3_Up();
        P4_Right();
    }

    public void RoundThree()
    {
        P1_Left();
        P2_Up();
        P3_Right();
        P4_Down();
    }

    public void RoundFour()
    {
        P1_Up();
        P2_Right();
        P3_Down();
        P4_Left();
    }
}