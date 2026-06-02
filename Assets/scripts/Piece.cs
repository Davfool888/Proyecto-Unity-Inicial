using UnityEngine;
using DG.Tweening;

public class Piece : MonoBehaviour
{


    public int x;
    public int y;
    public Board board;

    public enum type
    {
        elephant,
        giraffe,
        hippo,
        monkey,
        panda,
        parrot,
        penguin,
        pig,
        rabbit,
        snake

    }
    public type pieceType;

    public void Setup(int x_, int y_, Board board_)
    {
        x = x_;
        y = y_;
        board = board_;

    }

    public void Move(int dexX, int dexY)
    {
        transform.DOMove(new Vector3(dexX, dexY, -5f), 0.25f).SetEase(Ease.InOutCubic).onComplete = () =>
        {
            x = dexX;
            y = dexY;

        };
    }

    [ContextMenu("Test Move")]
    public void moveTest()
    {
        Move(0, 0);
    }
}
