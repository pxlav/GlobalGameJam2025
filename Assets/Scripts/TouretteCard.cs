using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouretteCard : MonoBehaviour
{
    public int cardClass;
    public bool isDragging;
    public Transform rootCard;
    public Tower tower;

    private void OnMouseDown()
    {
        isDragging = true;
    }
    private void OnMouseUp()
    {
        isDragging = false;
        this.transform.position = rootCard.transform.position;
    }
    private void Update()
    {
        if(isDragging)
        {
            Vector2 MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(MousePosition);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Tower")
        {
            tower = collision.gameObject.GetComponent<Tower>();
            if(tower.whichClass == 0)
            {
                tower.whichClass = cardClass;
                tower.isChanging = true;
                isDragging = false;
            }
        }
    }
}
