using UnityEngine;
using DG.Tweening;
internal class PlayerFourController : ExperimentEvent
{
    private GameObject player4;
    private ExperimentCallBack callBack;

    public PlayerFourController(GameObject player4, ExperimentCallBack callBack)
    {
        this.player4 = player4;
        this.callBack = callBack;
    }

    //------------------------------------------ SUBSCRIBE & UN-SUBSCRIBE --------------------------------->>

    public void AddListner()
    {
        ExperimentCallBack.P4_Right += MoveRight;
        ExperimentCallBack.P4_Left += MoveLeft;
        ExperimentCallBack.P4_Down += MoveDown;
        ExperimentCallBack.P4_Up += MoveUp;
    }

    public void RemoveListner()
    {
        ExperimentCallBack.P4_Right -= MoveRight;
        ExperimentCallBack.P4_Left -= MoveLeft;
        ExperimentCallBack.P4_Down -= MoveDown;
        ExperimentCallBack.P4_Up -= MoveUp;
    }

    //----------------------------------------------------- FUNCTIONALITY ----------------------------------->>
    private void MoveRight()
    {
        player4.transform.DOLocalMoveX(3.5f, 1f);
    }
    private void MoveLeft()
    {
        player4.transform.DOLocalMoveX(-3.5f, 1f);
    }
    private void MoveDown()
    {
        player4.transform.DOLocalMoveY(-1f, 1f);
    }
    private void MoveUp()
    {
        player4.transform.DOLocalMoveY(2f, 1f);
    }
}