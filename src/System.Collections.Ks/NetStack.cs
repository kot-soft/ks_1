using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Ks
{
	public class NetStack<T> : Stack<T>, IStack<T>
	{
		public void PushBegin(T item) => throw new NotImplementedException();
		public void PushEnd(T item) => base.Push(item);
		public T PopBegin() => throw new NotImplementedException();
		public T PopEnd() => base.Pop();
		public T Begin => throw new NotImplementedException();
		public T End => base.Peek();
		public void PushRangeBegin(params T[] items) => throw new NotImplementedException();
		public void PushRangeBegin(IEnumerable<T> items) => throw new NotImplementedException();
		public void PushRangeEnd(params T[] items) => PushRangeEnd(items as IEnumerable<T>);
		public void PushRangeEnd(IEnumerable<T> items) { foreach (var item in items) base.Push(item); }
		public IEnumerable<T> PopRangeBegin(int count) => throw new NotImplementedException();
		public IEnumerable<T> PopRangeEnd(int count)
		{
			var result = new T[Math.Min(count, Count)];
			for (int index = result.Length - 1; index >= 0; index--)
			{
				result[index] = base.Pop();
			}
			return result;
		}
	}
}
