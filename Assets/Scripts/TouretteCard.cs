using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouretteCard : MonoBehaviour
{
    public int cardClass;
    public bool isDragging;
    public Transform rootCard;
    public Tower tower;
    public float firstY;
    public float highLightY;

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
        if (isDragging)
        {
            Vector2 MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(MousePosition);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tower")
        {
            tower = collision.gameObject.GetComponent<Tower>();
            if (tower.whichClass == 0)
            {
                tower.whichClass = cardClass;
                tower.isChanging = true;
                isDragging = false;
            }
        }
    }
    private void OnMouseEnter()
    {
        this.transform.position = new Vector3(this.transform.position.x, highLightY, this.transform.position.z);
    }
    private void OnMouseExit()
    {
        transform.position = new Vector3(this.transform.position.x, firstY, this.transform.position.z);
    }
}
