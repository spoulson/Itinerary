using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Expl.Auxiliary.Sequence {
   /// <summary>
   /// Useful extensions for IEnumerable ordered sequences.
   /// </summary>
   public static class SequenceExtensions {
      /// <summary>
      /// Flatten multiple sequences into a single sequence, preserving order.
      /// </summary>
      /// <typeparam name="T">Enumerated type.</typeparam>
      /// <param name="inputSequences">List of input sequences.</param>
      /// <param name="comparer">Delegate to compare two input objects; like IComparer.CompareTo.</param>
      /// <returns>Result sequence.</returns>
      public static IEnumerable<T> SequenceFlatten<T>(this IEnumerable<T>[] inputSequences, Comparison<T> comparer) {
         return new SequenceSetFlatten<T>(inputSequences, comparer);
         }

      /// <summary>
      /// Flatten multiple sequences into a single sequence, preserving order.
      /// </summary>
      /// <typeparam name="T">Enumerated type which implements IComparable.</typeparam>
      /// <param name="inputSequences">List of input sequences.</param>
      /// <returns>Result sequence.</returns>
      public static IEnumerable<T> SequenceFlatten<T>(this IEnumerable<T>[] inputSequences) where T : IComparable<T> {
         return new SequenceSetFlatten<T>(inputSequences, (x, y) => x.CompareTo(y));
      }

      /// <summary>
      /// Get sequence where input sequence intersects domain sequence.
      /// </summary>
      /// <typeparam name="T">Enumerated type that implements IComparable.</typeparam>
      /// <param name="inputSequence">Input sequence.</param>
      /// <param name="domainSequence">Domain sequence.</param>
      /// <param name="comparer">Delegate to compare two input objects; like IComparer.CompareTo.</param>
      /// <returns>Result sequence.</returns>
      public static IEnumerable<T> SequenceIntersection<T>(this IEnumerable<T> inputSequence, IEnumerable<T> domainSequence, Comparison<T> comparer) {
         IEnumerator<T> inputEnum = inputSequence.GetEnumerator();
         IEnumerator<T> domainEnum = domainSequence.GetEnumerator();
         bool domainDataFlag = domainEnum.MoveNext();

         for (bool inputDataFlag = inputEnum.MoveNext(); inputDataFlag; ) {

            if (domainDataFlag) {
               int cmp = comparer(inputEnum.Current, domainEnum.Current);
               // If input is less than domain, no match; continue loop
               if (cmp < 0) continue;
               // If input is greater than domain, iterate domain and loop to retest
               else if (cmp > 0) {
                  domainDataFlag = domainEnum.MoveNext();
                  continue;
               }
               // If equal, fall through to return input element
            }
            else {
               // No more domain elements, no more possible matches; exit loop
               break;
            }

            yield return inputEnum.Current;
            inputDataFlag = inputEnum.MoveNext();
         }

         yield break;
      }

      /// <summary>
      /// Get sequence where input sequence intersects domain sequence.
      /// </summary>
      /// <typeparam name="T">Enumerated type that implements IComparable.</typeparam>
      /// <param name="inputSequence">Input sequence.</param>
      /// <param name="domainSequence">Domain sequence.</param>
      /// <returns>Result sequence.</returns>
      public static IEnumerable<T> SequenceIntersection<T>(this IEnumerable<T> inputSequence, IEnumerable<T> domainSequence) where T : IComparable<T> {
         return SequenceIntersection(inputSequence, domainSequence, (a, b) => a.CompareTo(b));
      }

      /// <summary>
      /// Get sequence where input sequence differs domain sequence.
      /// </summary>
      /// <typeparam name="T">Enumerated type.</typeparam>
      /// <param name="inputSequence">Input sequence.</param>
      /// <param name="domainSequence">Domain sequence.</param>
      /// <param name="comparer">Delegate to compare two input objects; like IComparer.CompareTo.</param>
      /// <returns>Result sequence.</returns>
      public static IEnumerable<T> SequenceDifference<T>(this IEnumerable<T> inputSequence, IEnumerable<T> domainSequence, Comparison<T> comparer) {
         IEnumerator<T> inputEnum = inputSequence.GetEnumerator();
         IEnumerator<T> domainEnum = domainSequence.GetEnumerator();
         bool domainDataFlag = domainEnum.MoveNext();

         for (bool inputDataFlag = inputEnum.MoveNext(); inputDataFlag; ) {

            if (domainDataFlag) {
               int cmp = comparer(inputEnum.Current, domainEnum.Current);
               // If input is less than domain, no match; return element
               if (cmp < 0) yield return inputEnum.Current;
               // If input is greater than domain, iterate domain and loop to retest
               else if (cmp > 0) {
                  domainDataFlag = domainEnum.MoveNext();
                  continue;
               }
               // If equal, fall through to iterate without returning input element
            }
            else {
               // No more domain elements, return input element
               yield return inputEnum.Current;
            }

            // Iterate input
            inputDataFlag = inputEnum.MoveNext();
         }

         yield break;
      }

      /// <summary>
      /// Get sequence where input sequence differs domain sequence.
      /// </summary>
      /// <typeparam name="T">Enumerated type that implements IComparable.</typeparam>
      /// <param name="inputSequence">Input sequence.</param>
      /// <param name="domainSequence">Domain sequence.</param>
      /// <returns>Result sequence.</returns>
      public static IEnumerable<T> SequenceDifference<T>(this IEnumerable<T> inputSequence, IEnumerable<T> domainSequence) where T : IComparable<T> {
         return SequenceDifference(inputSequence, domainSequence, (a, b) => a.CompareTo(b));
      }

      /// <summary>
      /// Get union sequence of input sequences.
      /// </summary>
      /// <typeparam name="T">Enumerated type.</typeparam>
      /// <param name="inputSequence">Input sequences.</param>
      /// <param name="comparer">Delegate to compare two input objects; like IComparer.CompareTo.</param>
      /// <returns>Result sequence.</returns>
      public static IEnumerable<T> SequenceUnion<T>(this IEnumerable<T>[] inputSequences, Comparison<T> comparer) {
         return new SequenceSetUnion<T>(inputSequences, comparer);
      }

      /// <summary>
      /// Get union sequence of input sequences.
      /// </summary>
      /// <typeparam name="T">Enumerated type.</typeparam>
      /// <param name="inputSequence">Input sequence.</param>
      /// <param name="additionalSequences">Additional input sequences.</param>
      /// <returns>Result sequence.</returns>
      public static IEnumerable<T> SequenceUnion<T>(this IEnumerable<T>[] inputSequences) where T : IComparable<T> {
         return new SequenceSetUnion<T>(inputSequences, (a, b) => a.CompareTo(b));
      }

      /// <summary>
      /// Compute flattened sequence from input sequences.
      /// </summary>
      /// <typeparam name="T">Enumerated type.</typeparam>
      private class SequenceSetFlatten<T> : SequenceSetBase<T> {
         public SequenceSetFlatten(IEnumerable<T>[] inputSequences, Comparison<T> comparer) : base(inputSequences, comparer) { }

         public override IEnumerator<T> GetEnumerator() {
            var iterators = GetIterators();
            Iterator matchIterator = null;

            do {
               // Scan each iterator for a single minimum current value, according to Comparison delegate
               matchIterator = iterators
                  .Where(i => i.HasData)
                  .Aggregate((Iterator)null, (a, i) => (a == null || _comparer(i.Current, a.Current) < 0) ? i : a);

               if (matchIterator != null) {
                  // Return iterator, if found
                  yield return matchIterator.Current;
                  matchIterator.MoveNext();
               }

               // Continue until no more iterators found
            } while (matchIterator != null);

            yield break;
         }
      }

      /// <summary>
      /// Compute union sequence from input sequences.
      /// </summary>
      /// <typeparam name="T"></typeparam>
      private class SequenceSetUnion<T> : SequenceSetBase<T> {
         public SequenceSetUnion(IEnumerable<T>[] inputSequences, Comparison<T> comparer) : base(inputSequences, comparer) { }

         /// <summary>
         /// Flatten all sequences into single sequence of iterators.
         /// </summary>
         public override IEnumerator<T> GetEnumerator() {
            var iterators = GetIterators();
            var matchIterators = new List<Iterator>();

            do {
               // Scan each iterator for all iterators matching minimum current value,
               // according to Comparison delegate
               matchIterators.Clear();
               foreach (var i in iterators.Where(i => i.HasData)) {
                  var fi = matchIterators.FirstOrDefault();
                  if (fi == null || _comparer(fi.Current, i.Current) == 0) {
                     // Add if first element or values match
                     matchIterators.Add(i);
                  }
                  else if (_comparer(i.Current, fi.Current) < 0) {
                     // New minimum found, clear list and add this iterator
                     matchIterators.Clear();
                     matchIterators.Add(i);
                  }
               }

               var retIterator = matchIterators.FirstOrDefault();
               if (retIterator != null) {
                  // Return iterator, if found
                  yield return retIterator.Current;

                  // Advance each iterator
                  foreach (var i in matchIterators) {
                     i.MoveNext();
                  }
               }

               // Continue until no more iterators found
            } while (matchIterators.Count > 0);

            yield break;
         }
      }

      /// <summary>
      /// Base class for aggregation functions on a list of sequences.
      /// </summary>
      /// <typeparam name="T">Enumerated type.</typeparam>
      private abstract class SequenceSetBase<T> : IEnumerable<T> {
         protected IEnumerable<T>[] _inputSequences;
         protected Comparison<T> _comparer;

         public SequenceSetBase(IEnumerable<T>[] inputSequences, Comparison<T> comparer) {
            _inputSequences = inputSequences;
            _comparer = comparer;
         }

         /// <summary>
         /// Convert inputSequences to array of Iterators.
         /// </summary>
         /// <returns></returns>
         protected Iterator[] GetIterators() {
            return _inputSequences.Select(e => new Iterator(e.GetEnumerator())).ToArray();
         }

         /// <summary>
         /// Wraps IEnumerator to alter usage pattern.
         /// Provides new HasData property.  No need to call MoveNext() before first access.
         /// </summary>
         /// <typeparam name="T">Enumerated type.</typeparam>
         protected class Iterator : IEnumerator<T> {
            private IEnumerator<T> _enumerator;
            private int _counter = 0;

            public Iterator(IEnumerator<T> enumerator) {
               _enumerator = enumerator;
               MoveNext();
            }

            public bool HasData { get; private set; }

            #region IEnumerator<T> Members

            public T Current {
               get { return _enumerator.Current; }
            }

            #endregion

            #region IDisposable Members

            public void Dispose() {
               _enumerator.Dispose();
            }

            #endregion

            #region IEnumerator Members

            object System.Collections.IEnumerator.Current {
               get { return _enumerator.Current; }
            }

            public bool MoveNext() {
               HasData = _enumerator.MoveNext();
               if (HasData) _counter++;
               return HasData;
            }

            public void Reset() {
               _enumerator.Reset();
            }

            #endregion
         }

         #region IEnumerable<T> Members

         public abstract IEnumerator<T> GetEnumerator();

         #endregion

         #region IEnumerable Members

         System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return (System.Collections.IEnumerator)GetEnumerator();
         }

         #endregion
      }
   }
}
