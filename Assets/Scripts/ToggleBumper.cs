using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleBumper : Bumpers
{
    private SpriteRenderer spr;
    public Color On;
    public Color Off;
    private BumperGroup bumperGroup;

    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.color = Off;
    }

    public override void ChangeColor()
    {
        if(spr.color == Off)
        {
            bumperGroup.On();
            spr.color = On;
        }
        else
        {
            bumperGroup.Off();
            spr.color = Off;
        }
    }
    public void SetBumperGroup(BumperGroup bumpers)
    {
        bumperGroup = bumpers;
    }
    public void Restart()
    {
        spr.color = Off;
    }
}
