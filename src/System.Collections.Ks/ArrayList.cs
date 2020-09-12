using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Ks
{
	public class ArrayList<T> : IList<T>, ILinearContainer<T>
	{
		#region IList
		public int IndexOf(T item)
		{
			throw new NotImplementedException();
		}
		public void Insert(int index, T item)
		{
			throw new NotImplementedException();
		}
		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}
		public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public void Add(T item)
		{
			throw new NotImplementedException();
		}
		public void Clear()
		{
			throw new NotImplementedException();
		}
		public bool Contains(T item)
		{
			throw new NotImplementedException();
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}
		public bool Remove(T item)
		{
			throw new NotImplementedException();
		}
		public int Count => throw new NotImplementedException();
		public bool IsReadOnly => throw new NotImplementedException();
		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
		#endregion
		#region ILinearContainer

		public void PushBegin(T item)
		{
			throw new NotImplementedException();
		}

		public void PushEnd(T item)
		{
			throw new NotImplementedException();
		}

		public T PopBegin()
		{
			throw new NotImplementedException();
		}

		public T PopEnd()
		{
			throw new NotImplementedException();
		}

		public T Begin => throw new NotImplementedException();

		public T End => throw new NotImplementedException();

		public void PushRangeBegin(params T[] items)
		{
			throw new NotImplementedException();
		}

		public void PushRangeBegin(IEnumerable<T> items)
		{
			throw new NotImplementedException();
		}

		public void PushRangeEnd(params T[] items)
		{
			throw new NotImplementedException();
		}

		public void PushRangeEnd(IEnumerable<T> items)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> PopRangeBegin(int count)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> PopRangeEnd(int count)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
