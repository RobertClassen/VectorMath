namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;
	using NumericMath.Core;
	using UnityEngine;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Linearly interpolates between both vectors by <c>t</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.LerpUnclamped.html  
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html
		/// </remarks>
		public static Vector3 Lerp(this float t, Vector3 a, Vector3 b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return new Vector3(
				t.Lerp(a.x, b.x, isClamped), 
				t.Lerp(a.y, b.y, isClamped), 
				t.Lerp(a.z, b.z, isClamped));
		}
	}
}