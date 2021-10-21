namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using WellDefinedNumerics;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Performs a component-wise `Sign` operation.
		/// </summary>
		public static Vector3 Sign(this Vector3 vector)
		{
			return new Vector3(vector.x.Sign(), vector.y.Sign(), vector.z.Sign());
		}
	}
}