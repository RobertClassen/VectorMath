namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath.Core;
	using UnityEngine;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Interpolates between both Quaternions by <c>t</c> and normalizes the result afterwards.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.LerpUnclamped.html  
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.Lerp.html
		/// </remarks>
		/// <seealso cref="Slerp"/>
		public static Quaternion Lerp(this float t, Quaternion a, Quaternion b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return isClamped ? Quaternion.Lerp(a, b, t) : Quaternion.LerpUnclamped(a, b, t);
		}
	}
}