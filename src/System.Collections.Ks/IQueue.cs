using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Ks
{
	public interface IQueue<T> : ILinearContainer<T>
	{
		void Enqueue(T item) => PushEnd(item);
		T Dequeue() => PopBegin();
		bool TryDequeue(out T item) { var result = Count > 0; item = result switch { true => Dequeue(), _ => default }; return result; }
		T Head => Begin;
		T Tail => End;
		T Seek() => Begin;
		bool TrySeek(out T item) { var result = Count > 0; item = result switch { true => Begin, _ => default }; return result; }
	}
}
