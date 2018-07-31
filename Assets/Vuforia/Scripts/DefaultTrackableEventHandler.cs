/*==============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using Vuforia;

/// <summary>
///     A custom handler that implements the ITrackableEventHandler interface.
/// </summary>
public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    #region PRIVATE_MEMBER_VARIABLES

    protected TrackableBehaviour mTrackableBehaviour;

    #endregion // PRIVATE_MEMBER_VARIABLES

	public AudioSource sound;
	public static bool F = false;
	public static bool F2 = false;
	public static bool F3 = false;
	public static bool H = false;
	public static bool H2 = false;
	public static bool H3 = false;
	public static bool O = false;
	public static bool N = false;
	public static bool Cl = false;
	public static bool Cl2 = false;
	public static bool Be = false;
	public static bool B = false;


    #region UNTIY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    #endregion // UNTIY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();

			sound.Play ();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NOT_FOUND)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();

			sound.Stop ();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS

    #region PRIVATE_METHODS

    protected virtual void OnTrackingFound()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Enable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Enable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Enable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;

		if (mTrackableBehaviour.TrackableName == "F")
			F = true;

		if (mTrackableBehaviour.TrackableName == "F2")
			F2 = true;

		if (mTrackableBehaviour.TrackableName == "F3")
			F3 = true;

		if (mTrackableBehaviour.TrackableName == "H")
			H = true;

		if (mTrackableBehaviour.TrackableName == "H2")
			H2 = true;

		if (mTrackableBehaviour.TrackableName == "H3")
			H3 = true;

		if (mTrackableBehaviour.TrackableName == "O")
			O = true;

		if (mTrackableBehaviour.TrackableName == "N")
			N = true;

		if (mTrackableBehaviour.TrackableName == "Cl")
			Cl = true;

		if (mTrackableBehaviour.TrackableName == "Cl2")
			Cl2 = true;

		if (mTrackableBehaviour.TrackableName == "Be")
			Be = true;

		if (mTrackableBehaviour.TrackableName == "B")
			B = true;
    }


    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;

		if (mTrackableBehaviour.TrackableName == "F")
			F = false;

		if (mTrackableBehaviour.TrackableName == "F2")
			F2 = false;

		if (mTrackableBehaviour.TrackableName == "F3")
			F3 = false;

		if (mTrackableBehaviour.TrackableName == "H")
			H = false;

		if (mTrackableBehaviour.TrackableName == "H2")
			H2 = false;

		if (mTrackableBehaviour.TrackableName == "H3")
			H3 = false;

		if (mTrackableBehaviour.TrackableName == "O")
			O = false;

		if (mTrackableBehaviour.TrackableName == "N")
			N = false;

		if (mTrackableBehaviour.TrackableName == "Cl")
			Cl = false;

		if (mTrackableBehaviour.TrackableName == "Cl2")
			Cl2 = true;

		if (mTrackableBehaviour.TrackableName == "Be")
			Be = false;

		if (mTrackableBehaviour.TrackableName == "B")
			B = false;
    }

    #endregion // PRIVATE_METHODS
}
