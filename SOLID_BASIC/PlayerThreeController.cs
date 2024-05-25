using UnityEngine;
using DG.Tweening;
internal class PlayerThreeController : ExperimentEvent
{
    private GameObject player3;
    private ExperimentCallBack callBack;

    public PlayerThreeController(GameObject player3, ExperimentCallBack callBack)
    {
        this.player3 = player3;
        this.callBack = callBack;
    }

    //------------------------------------------ SUBSCRIBE & UN-SUBSCRIBE --------------------------------->>

    public void AddListner()
    {
        ExperimentCallBack.P3_Right += MoveRight;
        ExperimentCallBack.P3_Left += MoveLeft;
        ExperimentCallBack.P3_Down += MoveDown;
        ExperimentCallBack.P3_Up += MoveUp;

    }

    public void RemoveListner()
    {
        ExperimentCallBack.P3_Right -= MoveRight;
        ExperimentCallBack.P3_Left -= MoveLeft;
        ExperimentCallBack.P3_Down -= MoveDown;
        ExperimentCallBack.P3_Up -= MoveUp;
    }

    //----------------------------------------------------- FUNCTIONALITY ----------------------------------->>
    private void MoveRight()
    {
        player3.transform.DOLocalMoveX(3.5f, 1f);
    }
    private void MoveLeft()
    {
        player3.transform.DOLocalMoveX(-3.5f, 1f);
    }
    private void MoveDown()
    {
        player3.transform.DOLocalMoveY(-1f, 1f);
    }
    private void MoveUp()
    {
        player3.transform.DOLocalMoveY(2f, 1f);
    }
}