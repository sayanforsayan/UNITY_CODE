using UnityEngine;
using DG.Tweening;
internal class PlayerTwoController : ExperimentEvent
{
    private GameObject player2;
    private ExperimentCallBack callBack;

    public PlayerTwoController(GameObject player2, ExperimentCallBack callBack)
    {
        this.player2 = player2;
        this.callBack = callBack;
    }


    //------------------------------------------ SUBSCRIBE & UN-SUBSCRIBE --------------------------------->>

    public void AddListner()
    {

        ExperimentCallBack.P2_Right += MoveRight;
        ExperimentCallBack.P2_Left += MoveLeft;
        ExperimentCallBack.P2_Down += MoveDown;
        ExperimentCallBack.P2_Up += MoveUp;
    }

    public void RemoveListner()
    {
        ExperimentCallBack.P2_Right -= MoveRight;
        ExperimentCallBack.P2_Left -= MoveLeft;
        ExperimentCallBack.P2_Down -= MoveDown;
        ExperimentCallBack.P2_Up -= MoveUp;
    }

    //----------------------------------------------------- FUNCTIONALITY ----------------------------------->>
    private void MoveRight()
    {
        player2.transform.DOLocalMoveX(3.5f, 1f);
    }
    private void MoveLeft()
    {
        player2.transform.DOLocalMoveX(-3.5f, 1f);
    }
    private void MoveDown()
    {
        player2.transform.DOLocalMoveY(-1f, 1f);
    }
    private void MoveUp()
    {
        player2.transform.DOLocalMoveY(2f, 1f);
    }
}