using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDefenders : MonoBehaviour
{
    Defender defender;

    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }

    public void SetDefender(Defender defender)
    {
        this.defender = defender;
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 mousePos)
    {
        Instantiate(defender, SnapToGrid(mousePos), Quaternion.identity);
    }
}
