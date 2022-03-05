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
		/// See https://docs.unity3d.com/ScriptReference/Vector4.LerpUnclamped.html  
		/// See https://docs.unity3d.com/ScriptReference/Vector4.Lerp.html
		/// </remarks>
		public static Vector4 Lerp(this float t, Vector4 a, Vector4 b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return new Vector4(
				t.Lerp(a.x, b.x, isClamped), 
				t.Lerp(a.y, b.y, isClamped), 
				t.Lerp(a.z, b.z, isClamped), 
				t.Lerp(a.w, b.w, isClamped));
		}
	}
}