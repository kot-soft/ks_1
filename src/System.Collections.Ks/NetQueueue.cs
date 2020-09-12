using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Ks
{
	public class NetQueueue<T> : Queue<T>, IQueue<T>
	{
		public void PushBegin(T item) => throw new NotImplementedException();
		public void PushEnd(T item) => base.Enqueue(item);
		public T PopBegin() => base.Dequeue();
		public T PopEnd() => throw new NotImplementedException();
		public T Begin => base.Peek();
		public T End => throw new NotImplementedException();
		public void PushRangeBegin(params T[] items) => throw new NotImplementedException();
		public void PushRangeBegin(IEnumerable<T> items) => throw new NotImplementedException();
		public void PushRangeEnd(params T[] items) => PushRangeEnd(items as IEnumerable<T>);
		public void PushRangeEnd(IEnumerable<T> items) { foreach (var item in items) base.Enqueue(item); }
		public IEnumerable<T> PopRangeBegin(int count)
		{
			var result = new T[Math.Min(count, Count)];
			for (int index = 0; index < result.Length; index++)
			{
				result[index] = base.Dequeue();
			}
			return result;
		}
		public IEnumerable<T> PopRangeEnd(int count) => throw new NotImplementedException();
	}
}
