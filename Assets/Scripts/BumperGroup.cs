using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperGroup : MonoBehaviour
{
    public List<ToggleBumper> bumperList;
    private int bumpersOn;

    void Start()
    {
        foreach (ToggleBumper bumper in bumperList)
        {
            bumper.SetBumperGroup(gameObject.GetComponent<BumperGroup>());
        }
    }

    public void On()
    {
        bumpersOn++;
        if (bumpersOn >= bumperList.Count)
        {
            Player.Instance.Combo();
            RestartB();
        }
    }
    public void Off()
    {
        bumpersOn--;
    }
	private void RestartB()
    {
        foreach(ToggleBumper bumper in bumperList)
        {
            bumper.Restart();
            bumpersOn = 0;
        }
    }
}
