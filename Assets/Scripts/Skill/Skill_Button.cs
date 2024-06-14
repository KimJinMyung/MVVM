using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Button : MonoBehaviour
{
    public void OnClick_LevelUp()
    {
        GameLogicManager.Inst.RequestLevelUpDouble();
    }

    public void OnClick_ChangedName()
    {
        GameLogicManager.Inst.RequestChangeName("Äô¾ß");
    }
}
