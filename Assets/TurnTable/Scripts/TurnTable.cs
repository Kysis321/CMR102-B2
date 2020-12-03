using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTable : MonoBehaviour
{
    public enum Direction {None = 0,Left = 1,Right = -1} // here we are assigning values to our enums to use in our calculations down below.
    public Direction currentMovementDirection; // the current direction we are moving in.
    public Transform transfromToRotate; // the object we want to rotate
    public float rotateSpeed = 100; // the speed we want to rotate at
    private Quaternion startingRotation; // the startin rotation
    private Quaternion currentRotation; // the current rotation we are at.

    // Start is called before the first frame update
    void Start()
    {
        startingRotation = transfromToRotate.rotation; // set our starting rotation
    }

    private void Update()
    {
        Rotate(); // tell our object to rotate
    }

    /// <summary>
    /// Rotates an object around it's local Y axis.
    /// </summary>
    void Rotate()
    {
        float currentY = transfromToRotate.rotation.eulerAngles.y; // grab our current local y rotation

        currentY = Mathf.MoveTowardsAngle(currentY, currentY + (int)currentMovementDirection, rotateSpeed * Time.deltaTime); // grab our new rotation i.e. +1 or -1 to our current rotation

        transfromToRotate.rotation = Quaternion.Euler(transfromToRotate.rotation.x, currentY, transfromToRotate.rotation.z); // update our current rotation to our new Y rotation
    }

    /// <summary>
    /// Cancels our object from rotating
    /// </summary>
    public void StopRotation()
    {
        currentMovementDirection = Direction.None;
    }

    /// <summary>
    /// Sets our current direction to moving left
    /// </summary>
    public void RotateLeft()
    {
        currentMovementDirection = Direction.Left;
    }

    /// <summary>
    /// Sets our current direction to right
    /// </summary>
    public void RotateRight()
    {
        currentMovementDirection = Direction.Right;
    }

    /// <summary>
    /// Resets our rotation to our startin position
    /// </summary>
    public void ResetRotation()
    {
        transfromToRotate.rotation = startingRotation;
    }
}
