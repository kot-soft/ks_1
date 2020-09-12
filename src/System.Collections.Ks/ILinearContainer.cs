using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Ks
{
	public interface ILinearContainer<T>
	{
		void PushBegin(T item);
		void PushEnd(T item);
		T PopBegin();
		T PopEnd();
		T Begin { get; }
		T End { get; }
		int Count { get; }
		void Clear();
		void PushRangeBegin(params T[] items);
		void PushRangeBegin(IEnumerable<T> items);
		void PushRangeEnd(params T[] items);
		void PushRangeEnd(IEnumerable<T> items);
		IEnumerable<T> PopRangeBegin(int count);
		IEnumerable<T> PopRangeEnd(int count);
	}
}
