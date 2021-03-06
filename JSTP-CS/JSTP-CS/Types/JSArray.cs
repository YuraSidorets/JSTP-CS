﻿using System.Collections.Generic;

namespace Jstp.Types {
	/// <summary> Represents JavaScript array type. </summary>
	public class JSArray: JSValue {

		private static readonly int DEFAULT_CAPACITY = 15;
		private List<JSValue> jsArray;

		/// <summary> Initializes a new instance of the Jstp.Types.JSArray class that is empty and has default capacity. </summary>
		public JSArray() {
			jsArray = new List<JSValue>(DEFAULT_CAPACITY);
			type = JSTypes.JSArray;
		}

		/// <summary> Initializes a new instance of the Jstp.Types.JSArray class using specified collection. </summary>
		/// <param name="collection"></param>
		public JSArray(IEnumerable<JSValue> collection) {
			jsArray = new List<JSValue>(collection);
		}

		/// <summary> Gets or sets the element at the specified index. </summary>
		/// <param name="i">The zero-based index of the element to get or set.</param>
		/// <returns></returns>
		public JSValue this[int i] {
			get {
				return (i >= 0 && i < jsArray.Count) ? jsArray[i] : JSUndefined.Undefined;
			}
			set {
				if (i > 0) {
					if( i > jsArray.Count) {
						while (jsArray.Count < i) {
							jsArray.Add(JSUndefined.Undefined);
						}

						jsArray.Add(value);
					}
					else {
						jsArray[i] = value;
					}
				}
			}
		}

		/// <summary>
		/// Adds object to the end of array.
		/// </summary>
		/// <param name="item">The object to be added to the end of the array</param>
		public void Push(JSValue item) {
			jsArray.Add(item);
		}

		/// <summary> Returns the string that represents current object. </summary>
		public override string ToString() {
			return "[" + string.Join(",", jsArray) + "]";
		}
	}
}
