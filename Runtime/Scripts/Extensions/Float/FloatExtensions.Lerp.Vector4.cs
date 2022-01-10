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
		public static Vector4 Lerp(this  float t, Vector4 vector, Vector4 other, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return new Vector4(
				t.Lerp(vector.x, other.x, isClamped), 
				t.Lerp(vector.y, other.y, isClamped), 
				t.Lerp(vector.z, other.z, isClamped), 
				t.Lerp(vector.w, other.w, isClamped));
		}
	}
}