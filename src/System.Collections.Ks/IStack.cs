using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Ks
{
	public interface IStack<T> : ILinearContainer<T>
	{
		void Push(T item) => PushEnd(item);
		T Pop() => PopEnd();
		bool TryPop(out T item) { var result = Count > 0; item = result switch { true => Pop(), _ => default }; return result; }
		T Seek() => End;
		bool TrySeek(out T item) { var result = Count > 0; item = result switch { true => End, _ => default }; return result; }
		IEnumerable<T> PopRange(int count) => PopRangeEnd(count);
	}
}
